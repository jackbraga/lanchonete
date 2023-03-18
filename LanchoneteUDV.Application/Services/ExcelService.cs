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

        public bool CriarPlanilhaRepasse(List<IEnumerable<RepasseFinanceiroExcelDTO>> planilhas)
        {
            try
            {

                var nomeArquivo = planilhas[0].First().DataEscala.ToString("yyyy_MM_dd");
                var dataEscala = planilhas[0].First().DataEscala.ToString("dd_MM_yyyy");

                string caminho = String.Format(@"C:\Lanchonete\RepasseTesouraria\Vendas_Lanchonete_{0}.xlsx", nomeArquivo);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();

                var workSheet = Planilha(planilhas[0],excel.Workbook.Worksheets.Add("Vendas - " + dataEscala));
                //var workSheetParceria = Planilha(planilhas[1], excel.Workbook.Worksheets.Add("Parcerias - " + dataEscala));


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

        private ExcelWorksheet Planilha(IEnumerable<RepasseFinanceiroExcelDTO> repasses, ExcelWorksheet workSheet)
        {
            workSheet.Row(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            workSheet.Cells[1, 1].Value = "Socio";
            workSheet.Cells[1, 2].Value = "Pagamento";
            workSheet.Cells[1, 3].Value = "Frente";
            workSheet.Cells[1, 4].Value = "Valor";
            workSheet.Cells[1, 5].Value = "Texto Granatum";
            workSheet.Cells["D:D"].Style.Numberformat.Format = "R$#,##0.00";
            workSheet.Cells["A:E"].Style.Font.Name = "Trebuchet MS";
            workSheet.Cells["A:E"].Style.Font.Size = 10;
            workSheet.Cells["A:E"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            workSheet.Cells["A:E"].Style.Border.Right.Style = ExcelBorderStyle.Thin;

            //workSheet.Cells["C"].

            int indice = 2;
            foreach (var repasse in repasses)
            {
                workSheet.Cells[indice, 1].Value = repasse.Nome;
                workSheet.Cells[indice, 2].Value = repasse.TipoPagamento;
                workSheet.Cells[indice, 3].Value = repasse.Frente;
                workSheet.Cells[indice, 4].Value = repasse.Valor;
                workSheet.Cells[indice, 5].Value = (string.IsNullOrEmpty(repasse.Parceria) ? repasse.Frente : repasse.Parceria) + " - " + repasse.DataEscala.ToString("dd/MM/yyyy"); ;
                indice++;
            }

            workSheet.Cells["A:E"].AutoFitColumns();

            return workSheet;
        }

    }
}
