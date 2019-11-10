GO

/****** Object: Table [dbo].[BENEFICIARIOS] Script Date: 11/9/2019 4:15:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TYPE BeneficiariosType AS TABLE
(
    [CPF]       VARCHAR (15) NOT NULL,
    [NOME]      VARCHAR (50) NOT NULL
);
