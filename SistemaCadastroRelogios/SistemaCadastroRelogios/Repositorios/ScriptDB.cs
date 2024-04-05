using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Cryptography.Xml;

namespace SistemaCadastroRelogios.Repositorios
{
    public class ScriptDB
    {
        //Script de criação do Banco de Dados com as Tabelas Relacionais

        //        CREATE TABLE TB_MARCA
        //(
        //    IDMRC_MRC INT PRIMARY KEY,
        //    MARCA_MRC VARCHAR(20) NOT NULL
        //)
        //GO

        //CREATE TABLE TB_RELOGIOCOR
        //(
        //    IDCOR_COR INT PRIMARY KEY,
        //    COLOR_COR VARCHAR(20) NOT NULL
        //)

        //CREATE TABLE TB_RELOGIO
        //(
        //    IDREL_REL INT PRIMARY KEY,
        //    IDMRC_REL INT FOREIGN KEY REFERENCES TB_MARCA(IDMRC_MRC),
        //    IDCOR_REL INT FOREIGN KEY REFERENCES TB_RELOGIOCOR(IDCOR_COR),
        //    PRECO_REL NUMERIC(16,2) NOT NULL,
        //    GARAN_REL VARCHAR(10) NOT NULL,
        //    REFER_REL VARCHAR(50) NOT NULL
        //)
        //GO

        //CREATE TABLE TB_CLIENTE
        //(
        //    IDCLI_CLI INT PRIMARY KEY,
        //    NOMCL_CLI VARCHAR(30) NOT NULL,
        //    TELCL_CLI INT NOT NULL
        //)
        //GO

        //CREATE TABLE TB_VENDEDOR
        //(
        //    IDVDD_VDD INT PRIMARY KEY,
        //    NOMVD_VDD VARCHAR(50) NOT NULL,
        //    TELVD_VDD INT NOT NULL
        //)
        //GO

        //CREATE TABLE TB_ESTOQUE
        //(
        //    IDEST_EST INT PRIMARY KEY

        //    IDREL_EST INT FOREIGN KEY REFERENCES TB_RELOGIO(IDREL_REL),
        //    QTEST_REL INT NULL,
        //    ATTET_EST DATETIME NULL
        //)
        //GO

        //CREATE TABLE TB_VENDA
        //(
        //    IDVEN_VEN INT PRIMARY KEY

        //    IDCLI_VEN INT FOREIGN KEY REFERENCES TB_CLIENTE(IDCLI_CLI),
        //    METPG_VEN VARCHAR(10) NOT NULL,
        //    PARCV_VEN INT NOT NULL,
        //	DTVEN_VEN DATETIME NULL
        //)
        //GO

        //CREATE TABLE TB_CONTROLEVENDA
        //(
        //    IDVEE_VEE INT PRIMARY KEY,
        //    IDREL_VEE INT FOREIGN KEY REFERENCES TB_RELOGIO(IDREL_REL),
        //    IDVEN_VEE INT FOREIGN KEY REFERENCES TB_VENDA(IDVEN_VEN)
        //)
        //GO
    }
}
