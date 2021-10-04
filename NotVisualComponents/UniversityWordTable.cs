using NotVisualComponents.HelperModels;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Reflection;

namespace NotVisualComponents
{
    public partial class UniversityWordTable : Component
    {
        public UniversityWordTable()
        {
            InitializeComponent();
        }

        public UniversityWordTable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDoc<T>(string parth, string title, List<T> enterData, List<int[]> consolidatedСolumns, Dictionary<string, int> columnNamesAndSize)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(parth, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body docBody = mainPart.Document.AppendChild(new Body());
                docBody.AppendChild(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> { (title, new WordTextProperties { Bold = true, Size = "48" }) },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));

                Table table = new Table();

                // Create a TableProperties object and specify its border information.  
                TableProperties tblProp = new TableProperties(
                    new TableBorders(new TopBorder()
                    { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 },
                        new BottomBorder()
                        { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 },
                        new LeftBorder()
                        { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 },
                        new RightBorder()
                        { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 },
                        new InsideHorizontalBorder()
                        { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 },
                        new InsideVerticalBorder()
                        { Val = new EnumValue<BorderValues>(BorderValues.Sawtooth), Size = 24 })
                );


                table.AppendChild<TableProperties>(tblProp);



                foreach (T data in enterData)
                {
                    TableRow tableRow = new TableRow();
                    foreach (string columnName in columnNamesAndSize.Keys)
                    {
                        TableCell tableCell = new TableCell();

                        foreach (PropertyInfo property in typeof(T).GetProperties())
                        {
                            if (property.Name.Equals(columnName))
                            {
                                tableCell.Append(
                                    new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = columnNamesAndSize[columnName].ToString() }),
                                    new Paragraph(new Run(new Text(property.GetValue(data).ToString())))
                                    );
                                break;
                            }
                        }

                        tableRow.Append(tableCell);
                    }
                    table.Append(tableRow);
                }

                docBody.Append(table);

            }

        }

        private static SectionProperties CreateSectionProperties()
        {
            SectionProperties properties = new SectionProperties();
            PageSize pageSize = new PageSize
            {
                Orient = PageOrientationValues.Portrait
            };
            properties.AppendChild(pageSize);
            return properties;
        }

        private static Paragraph CreateParagraph(WordParagraph paragraph)
        {
            if (paragraph != null)
            {
                Paragraph docParagraph = new Paragraph();

                docParagraph.AppendChild(CreateParagraphProperties(paragraph.TextProperties));
                foreach (var run in paragraph.Texts)
                {
                    Run docRun = new Run();
                    RunProperties properties = new RunProperties();
                    properties.AppendChild(new FontSize { Val = run.Item2.Size });
                    if (run.Item2.Bold)
                    {
                        properties.AppendChild(new Bold());
                    }
                    docRun.AppendChild(properties);
                    docRun.AppendChild(new Text
                    {
                        Text = run.Item1,
                        Space =
                   SpaceProcessingModeValues.Preserve
                    });
                    docParagraph.AppendChild(docRun);
                }
                return docParagraph;
            }

            return null;
        }

        private static ParagraphProperties CreateParagraphProperties(WordTextProperties paragraphProperties)
        {
            if (paragraphProperties != null)
            {
                ParagraphProperties properties = new ParagraphProperties();
                properties.AppendChild(new Justification()
                {
                    Val = paragraphProperties.JustificationValues
                });
                properties.AppendChild(new SpacingBetweenLines
                {
                    LineRule = LineSpacingRuleValues.Auto
                });
                properties.AppendChild(new Indentation());
                ParagraphMarkRunProperties paragraphMarkRunProperties = new
               ParagraphMarkRunProperties();
                if (!string.IsNullOrEmpty(paragraphProperties.Size))
                {
                    paragraphMarkRunProperties.AppendChild(new FontSize
                    {
                        Val =
                   paragraphProperties.Size
                    });
                }
                properties.AppendChild(paragraphMarkRunProperties);
                return properties;
            }
            return null;
        }
    }
}
