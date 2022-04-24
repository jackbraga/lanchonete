using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Services
{
    public class ExcelService : IExcelService
    {

        public bool CriarPlanilhaRepasse(IEnumerable<RepasseFinanceiroExcelDTO> repasses)
        {
            try
            {
                var dataEscala = repasses.First().DataEscala.ToString("yyyy_MM_dd");

                string caminho = String.Format(@"C:\Lanchonete\RepasseTesouraria\Vendas_Lanchonete_{0}.xlsx", dataEscala);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();

                var workSheet = excel.Workbook.Worksheets.Add(repasses.First().DataEscala.ToString("dd_MM_yyyy"));

                //workSheet.TabColor = System.Drawing.Color.Black;
                //workSheet.DefaultRowHeight = 12;

                //workSheet.Row(1).Height = 20;
                workSheet.Row(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;

                workSheet.Cells[1, 1].Value = "Socio";
                workSheet.Cells[1, 2].Value = "Pagamento";
                workSheet.Cells[1, 3].Value = "Frente";
                workSheet.Cells[1, 4].Value = "Valor";
                workSheet.Cells["D:D"].Style.Numberformat.Format =  "R$#,##0.00";
                workSheet.Cells["A:D"].Style.Font.Name = "Trebuchet MS";
                workSheet.Cells["A:D"].Style.Font.Size = 10;
                workSheet.Cells["A:D"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                workSheet.Cells["A:D"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                


                //workSheet.Cells["C"].

                int indice = 2;
                foreach (var repasse in repasses)
                {
                    workSheet.Cells[indice, 1].Value = repasse.Nome;
                    workSheet.Cells[indice, 2].Value = repasse.TipoPagamento;
                    workSheet.Cells[indice, 3].Value = repasse.Frente;
                    workSheet.Cells[indice, 4].Value = repasse.Valor;
                    indice++;
                }
                workSheet.Cells["A:D"].AutoFitColumns();
                if (File.Exists(caminho))
                {
                    File.Delete(caminho);
                }


                FileStream objFileStrm = File.Create(caminho);
                objFileStrm.Close();

                File.WriteAllBytes(caminho, excel.GetAsByteArray());

                excel.Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
