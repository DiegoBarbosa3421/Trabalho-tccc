-- MySQL Script generated by MySQL Workbench
-- Thu Apr 20 15:01:20 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema sgagricolatcc
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `sgagricolatcc` ;

-- -----------------------------------------------------
-- Schema sgagricolatcc
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sgagricolatcc` DEFAULT CHARACTER SET utf8 ;
USE `sgagricolatcc` ;

-- -----------------------------------------------------
-- Table `sgagricolatcc`.`cadastroserviço`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`cadastroserviço` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`cadastroserviço` (
  `idserviço` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tiposerviço` VARCHAR(100) NULL DEFAULT NULL,
  `valor` DOUBLE NULL DEFAULT NULL,
  `data` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idserviço`))
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`colaborador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`colaborador` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`colaborador` (
  `idColaborador` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomeColaborador` VARCHAR(45) NULL DEFAULT NULL,
  `contato` VARCHAR(45) NULL DEFAULT NULL,
  `endereço` VARCHAR(45) NULL DEFAULT NULL,
  `situação` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idColaborador`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`proprietario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`proprietario` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`proprietario` (
  `idproprietario` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomeProprieatrio` VARCHAR(100) NULL DEFAULT NULL,
  `logim` VARCHAR(45) NULL DEFAULT NULL,
  `cpf` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idproprietario`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`propriedade`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`propriedade` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`propriedade` (
  `idPropriedade` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tipocultivo` VARCHAR(45) NULL DEFAULT NULL,
  `nomePropriedade` VARCHAR(60) NULL DEFAULT NULL,
  `dataAquisição` DATE NULL DEFAULT NULL,
  `hareaHectares` DOUBLE NULL DEFAULT NULL,
  `valorPropriedade` DOUBLE NULL DEFAULT NULL,
  `Proprietario_idproprietario` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idPropriedade`),
  INDEX `fk_Proppiedade_Proprietario1_idx` (`Proprietario_idproprietario` ASC) VISIBLE,
  CONSTRAINT `fk_Proppiedade_Proprietario1`
    FOREIGN KEY (`Proprietario_idproprietario`)
    REFERENCES `sgagricolatcc`.`proprietario` (`idproprietario`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb3
COMMENT = '\\n';


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`talhão`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`talhão` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`talhão` (
  `idTalhão` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomeTalhão` VARCHAR(45) NULL DEFAULT NULL,
  `hareaHectares` DOUBLE NULL DEFAULT NULL,
  `tipodePlanta` VARCHAR(100) NULL DEFAULT NULL,
  `espaçamento` DOUBLE NULL DEFAULT NULL,
  `dataPlantio` DATE NULL DEFAULT NULL,
  `quantidadedePlantas` INT NULL DEFAULT NULL,
  `Propriedade_idPropriedade` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idTalhão`),
  INDEX `fk_Talhão_Propriedade1_idx` (`Propriedade_idPropriedade` ASC) VISIBLE,
  CONSTRAINT `fk_Talhão_Propriedade1`
    FOREIGN KEY (`Propriedade_idPropriedade`)
    REFERENCES `sgagricolatcc`.`propriedade` (`idPropriedade`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`execuçãoatividades`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`execuçãoatividades` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`execuçãoatividades` (
  `idExecuçãoAtividades` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `situação` VARCHAR(45) NULL DEFAULT NULL,
  `dataInicio` DATE NULL DEFAULT NULL,
  `dataTermino` DATE NULL DEFAULT NULL,
  `CadastroServiço_idserviço` INT UNSIGNED NOT NULL,
  `Colaborador_idColaborador` INT UNSIGNED NOT NULL,
  `Talhão_idTalhão` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idExecuçãoAtividades`),
  INDEX `fk_ExecuçaõServiço_CadastroServiço1_idx` (`CadastroServiço_idserviço` ASC) VISIBLE,
  INDEX `fk_ExecuçaõServiço_Colaborador1_idx` (`Colaborador_idColaborador` ASC) VISIBLE,
  INDEX `fk_ExecuçãoAtividades_Talhão1_idx` (`Talhão_idTalhão` ASC) VISIBLE,
  CONSTRAINT `fk_ExecuçaõServiço_CadastroServiço1`
    FOREIGN KEY (`CadastroServiço_idserviço`)
    REFERENCES `sgagricolatcc`.`cadastroserviço` (`idserviço`),
  CONSTRAINT `fk_ExecuçaõServiço_Colaborador1`
    FOREIGN KEY (`Colaborador_idColaborador`)
    REFERENCES `sgagricolatcc`.`colaborador` (`idColaborador`),
  CONSTRAINT `fk_ExecuçãoAtividades_Talhão1`
    FOREIGN KEY (`Talhão_idTalhão`)
    REFERENCES `sgagricolatcc`.`talhão` (`idTalhão`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`faturamento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`faturamento` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`faturamento` (
  `idFaturamento` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `valorTotalArrecadado` DOUBLE NULL DEFAULT NULL,
  `valorUnitarioArrecadado` DOUBLE NULL DEFAULT NULL,
  `dataFAturamento` DATE NULL DEFAULT NULL,
  `quantidadeFaturamento` DOUBLE NULL DEFAULT NULL,
  `tipoDeCafé` VARCHAR(45) NULL DEFAULT NULL,
  `Talhão_idTalhão` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idFaturamento`),
  INDEX `fk_Financeiro_Talhão1_idx` (`Talhão_idTalhão` ASC) VISIBLE,
  CONSTRAINT `fk_Financeiro_Talhão1`
    FOREIGN KEY (`Talhão_idTalhão`)
    REFERENCES `sgagricolatcc`.`talhão` (`idTalhão`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`ferramentas_e_equipamentos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`ferramentas_e_equipamentos` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`ferramentas_e_equipamentos` (
  `idFerramentas` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomeFerramenta` VARCHAR(100) NULL DEFAULT NULL,
  `valorFerramenta` DOUBLE NULL DEFAULT NULL,
  `datadeAquisição` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idFerramentas`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`insumos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`insumos` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`insumos` (
  `idInsumos` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomeInsumos` VARCHAR(100) NULL DEFAULT NULL,
  `valorUnitario` DOUBLE NULL DEFAULT NULL,
  `valortotal` DOUBLE NULL DEFAULT NULL,
  `quantidadeComprada` DOUBLE NULL DEFAULT NULL,
  `observação` VARCHAR(100) NULL DEFAULT NULL,
  `dataAquisiçao` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idInsumos`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`manutenção_equipamentos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`manutenção_equipamentos` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`manutenção_equipamentos` (
  `idManutenção` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `tipoManutenção` VARCHAR(150) NULL DEFAULT NULL,
  `valorManutenção` DOUBLE NULL DEFAULT NULL,
  `dataManutenção` DATE NULL DEFAULT NULL,
  `Ferramentas_e_Equipamentos_idFerramentas` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idManutenção`),
  INDEX `fk_Manutenção_Equipamentos_Ferramentas_e_Equipamentos1_idx` (`Ferramentas_e_Equipamentos_idFerramentas` ASC) VISIBLE,
  CONSTRAINT `fk_Manutenção_Equipamentos_Ferramentas_e_Equipamentos1`
    FOREIGN KEY (`Ferramentas_e_Equipamentos_idFerramentas`)
    REFERENCES `sgagricolatcc`.`ferramentas_e_equipamentos` (`idFerramentas`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `sgagricolatcc`.`produção`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sgagricolatcc`.`produção` ;

CREATE TABLE IF NOT EXISTS `sgagricolatcc`.`produção` (
  `idprodução` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `quantidade` DOUBLE NULL DEFAULT NULL,
  `dataInicio` DATE NULL DEFAULT NULL,
  `dataTermino` DATE NULL DEFAULT NULL,
  `custoUnitario` DOUBLE NULL DEFAULT NULL,
  `observação` VARCHAR(100) NULL DEFAULT NULL,
  `Colaborador_idColaborador` INT UNSIGNED NOT NULL,
  `Talhão_idTalhão` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idprodução`),
  INDEX `fk_produçao_Colaborador1_idx` (`Colaborador_idColaborador` ASC) VISIBLE,
  INDEX `fk_Produçao_Talhaõ1_idx` (`Talhão_idTalhão` ASC) VISIBLE,
  CONSTRAINT `fk_produçao_Colaborador1`
    FOREIGN KEY (`Colaborador_idColaborador`)
    REFERENCES `sgagricolatcc`.`colaborador` (`idColaborador`),
  CONSTRAINT `fk_Produçao_Talhaõ1`
    FOREIGN KEY (`Talhão_idTalhão`)
    REFERENCES `sgagricolatcc`.`talhão` (`idTalhão`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
