--
-- Banco de dados: `rede`
--

CREATE DATABASE `rede`;

--
-- Estrutura da tabela `compra`
--

DROP TABLE IF EXISTS `rede`.`compra`;
CREATE TABLE IF NOT EXISTS `compra` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `produtocomprado` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `compra`
--

INSERT INTO `rede`.`compra` (`id`, `usuario`, `produtocomprado`) VALUES
(2, 'Joao Victor', 'Sabonete'),
(3, 'Victor', 'Alicate de unha');

-- --------------------------------------------------------

--
-- Estrutura da tabela `loginproduto`
--

DROP TABLE IF EXISTS `rede`.`loginproduto`;
CREATE TABLE IF NOT EXISTS `loginproduto` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `loginproduto`
--

INSERT INTO `rede`.`loginproduto` (`id`, `nome`, `senha`) VALUES
(1, 'Joao', '123'),
(2, 'Victor', '123');