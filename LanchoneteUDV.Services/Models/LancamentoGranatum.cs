using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Services.Models
{
    public class LancamentoGranatum
    {
        [JsonProperty("id")]
        public int? id { get; set; }
        public int? grupo_id { get; set; }
        public int? lancamento_transferencia_id { get; set; }
        public int? categoria_id { get; set; }

        public int? centro_custo_lucro_id { get; set; }

        public int? tipo_custo_nivel_producao_id { get; set; }

        public int? tipo_custo_apropriacao_produto_id { get; set; }

        public int? conta_id { get; set; }

        public int? forma_pagamento_id { get; set; }

        public int? pessoa_id { get; set; }
        public int? tipo_lancamento_id { get; set; }

        public string descricao { get; set; }

        public int? tipo_documento_id { get; set; }

        public string documento { get; set; }
        public string status { get; set; }
        public bool? infinito { get; set; }

        public DateTime? data_vencimento { get; set; }

        public DateTime? data_pagamento { get; set; }

        public DateTime? data_competencia { get; set; }

        public string observacao { get; set; }

        public bool? pagamento_automatico { get; set; }

        public int? numero_repeticao { get; set; }

        public int? total_repeticoes { get; set; }

        public int? periodicidade { get; set; }

        public int? pedido_id { get; set; }

        public int? lancamento_composto_id { get; set; }

        public int? wgi_usuario_id { get; set; }


        public Double? valor { get; set; }

       
        public DateTime? modified { get; set; }

        public List<anexo>? anexos { get; set; }

        public List<tag>? tags { get; set; }

        public List<LancamentoGranatum>? itens_adicionais { get; set; }

    }

    public class anexo
    {
        public int? id { get; set; }
    }

    public class tag
    {
        public int? id { get; set; }
    }


    //public class item_adicional
    //{
    //    public int id { get; set; }
    //    public int grupo_id { get; set; }
    //    public int lancamento_transferencia_id { get; set; }
    //    public int categoria_id { get; set; }

    //    public int centro_custo_lucro_id { get; set; }

    //    public int tipo_custo_nivel_producao_id { get; set; }

    //    public int tipo_custo_apropriacao_produto_id { get; set; }

    //    public int conta_id { get; set; }

    //    public int forma_pagamento_id { get; set; }

    //    public int pessoa_id { get; set; }
    //    public int tipo_lancamento_id { get; set; }

    //    public string descricao { get; set; }

    //    public int tipo_documento_id { get; set; }

    //    public string documento { get; set; }

    //    public DateTime data_vencimento { get; set; }

    //    public Double valor { get; set; }

    //    public DateTime data_pagamento { get; set; }

    //    public DateTime data_competencia { get; set; }

    //    public string observacao { get; set; }

    //    public bool pagamento_automatico { get; set; }

    //    public int numero_repeticao { get; set; }

    //    public int total_repeticoes { get; set; }

    //    public int periodicidade { get; set; }

    //    public int pedido_id { get; set; }

    //    public int lancamento_composto_id { get; set; }

    //    public DateTime modified { get; set; }

    //    public List<anexo> anexos { get; set; }

    //    public List<tag> tags { get; set; }

    //    public List<item_adicional> itens_adicionais { get; set; }

    //}




}

