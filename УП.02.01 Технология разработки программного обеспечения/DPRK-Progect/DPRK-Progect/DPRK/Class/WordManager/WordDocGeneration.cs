using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DPRK.Class.WordManager
{
    class WordDocGeneration
    {

        SQL.SQLManager sqlManager = new SQL.SQLManager();
       
        public string addFile(string valueObject, int[] idSubmissionWork, string [] titleObj,string region)
        {
            try
            {
                string pathDocument = AppDomain.CurrentDomain.BaseDirectory + $@"Отчет от {DateTime.Now.ToShortDateString()} {valueObject} Участок-{region}.docx";
                DocX document = DocX.Create(pathDocument);
                int i = 0;
                foreach (int idSubm in idSubmissionWork)
                {
                    DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Working_Material_Inform] ({idSubm})");
                    int countRow = dataTable.Rows.Count;
                    if (countRow > 0)
                    {
                        title(document, titleObj[i]);
                        title(document, "Используемые материалы: ");
                        Paragraph paragraph = document.InsertParagraph();
                        for (int j = 0; j < countRow; j++)
                        {
                            stringValue($@"{dataTable.Rows[j][4]} {dataTable.Rows[j][5]} штук", paragraph);
                        }

                        paragraph.AppendLine();
                    }
                    i++;
                }
                document.Save();
                return pathDocument;
            }
            catch
            {
                return "Закройте файл.";
            }
        }

        /// <summary>
        /// Создание заголовка в word документе
        /// </summary>
        /// <param name="document">Документ с котрым работаем</param>
        /// <param name="value">Значение для заголовка</param>
        /// <returns></returns>
        Alignment title(DocX document,string value) 
        { 
            return document.InsertParagraph(value).
                     Font("Times New Roman").
                     FontSize(10).
                     Color(Color.Black).
                     Bold().
                     Alignment = Alignment.center;
        }

        /// <summary>
        /// Создание строки в документе word
        /// </summary>
        /// <param name="value">Значение для занесения</param>
        /// <param name="paragraph">Параграф документа</param>
        /// <returns>
        /// Парашрафф с текстом
        /// </returns>
        Paragraph stringValue(string value,Paragraph paragraph)
        {
            paragraph.Alignment = Alignment.left;
            return paragraph.AppendLine(value).
                     FontSize(12).
                     Font("Times New Roman").
                     Color(Color.Black);
        }
    }
}
