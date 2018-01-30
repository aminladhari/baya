-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 30 jan. 2018 à 21:06
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `baya`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id_client` int(10) NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `cin` varchar(20) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`id_client`, `nom`, `prenom`, `cin`, `adresse`) VALUES
(2, 'Ladhari', 'Mohamed Amine', '09326649', '55 rue sbitla 4070 msaken');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `tva` varchar(20) NOT NULL,
  `totale_htva` varchar(20) NOT NULL,
  `totale_tva` varchar(20) NOT NULL,
  `totoale_ttc` varchar(20) NOT NULL,
  `date` varchar(50) NOT NULL,
  `nom_prenom` varchar(50) NOT NULL,
  `cin` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `tva`, `totale_htva`, `totale_tva`, `totoale_ttc`, `date`, `nom_prenom`, `cin`) VALUES
(1, '18', '187200', '33696', '220896', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(2, '18', '93,6', '16,848', '110,448', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(3, '18', '50', '9', '59', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(4, '18', '26', '4,68', '30,68', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(5, '18', '34', '6,12', '40,12', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(6, '18', '55', '9,900001', '64,9', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649'),
(7, '18', '180', '32,4', '212,4', 'mardi 30 janvier 2018', 'Ladhari Mohamed Amine', '09326649');

-- --------------------------------------------------------

--
-- Structure de la table `details`
--

DROP TABLE IF EXISTS `details`;
CREATE TABLE IF NOT EXISTS `details` (
  `id_dc` int(10) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) NOT NULL,
  `metrage` varchar(20) NOT NULL,
  `epaisseur` varchar(20) NOT NULL,
  `designation` varchar(20) NOT NULL,
  `quantite` varchar(20) NOT NULL,
  `prix` varchar(20) NOT NULL,
  `prix_tt` varchar(20) NOT NULL,
  `cin` varchar(20) NOT NULL,
  PRIMARY KEY (`id_dc`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `detail_commande`
--

DROP TABLE IF EXISTS `detail_commande`;
CREATE TABLE IF NOT EXISTS `detail_commande` (
  `id_dc` int(10) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) NOT NULL,
  `metrage` varchar(20) NOT NULL,
  `epaisseur` varchar(20) NOT NULL,
  `designation` varchar(20) NOT NULL,
  `quantite` varchar(20) NOT NULL,
  `prix` varchar(20) NOT NULL,
  `prix_tt` varchar(20) NOT NULL,
  `cin` varchar(20) NOT NULL,
  `nom_prenom` varchar(50) NOT NULL,
  PRIMARY KEY (`id_dc`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `detail_commande`
--

INSERT INTO `detail_commande` (`id_dc`, `type`, `metrage`, `epaisseur`, `designation`, `quantite`, `prix`, `prix_tt`, `cin`, `nom_prenom`) VALUES
(1, 'Marbre', '2,60', '3', 'tala gris', '2', '12000', '62400', '09326649', 'Ladhari Mohamed Amine'),
(2, 'Granit', '2,60', '3', 'noir galaxy', '3', '12,000', '93,6', '09326649', 'Ladhari Mohamed Amine'),
(3, 'Marbre', '2,50', '2', 'tala', '2', '10,000', '50', '09326649', 'Ladhari Mohamed Amine'),
(4, 'Granit', '2,60', '2', 'gris messi', '1', '10,000', '26', '09326649', 'Ladhari Mohamed Amine'),
(5, 'Marbre', '3,40', '2', 'chevreuné', '1', '10,000', '34', '09326649', 'Ladhari Mohamed Amine'),
(6, 'Marbre', '2,75', '2', 'tala gris', '2', '10,000', '55', '09326649', 'Ladhari Mohamed Amine'),
(7, 'Marbre', '2,50', '3', 'tala', '6', '12,000', '180', '09326649', 'Ladhari Mohamed Amine');

-- --------------------------------------------------------

--
-- Structure de la table `epaisseur`
--

DROP TABLE IF EXISTS `epaisseur`;
CREATE TABLE IF NOT EXISTS `epaisseur` (
  `id_epaisseur` int(10) NOT NULL AUTO_INCREMENT,
  `valeur` varchar(20) NOT NULL,
  PRIMARY KEY (`id_epaisseur`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `epaisseur`
--

INSERT INTO `epaisseur` (`id_epaisseur`, `valeur`) VALUES
(1, '2'),
(2, '3');

-- --------------------------------------------------------

--
-- Structure de la table `granit`
--

DROP TABLE IF EXISTS `granit`;
CREATE TABLE IF NOT EXISTS `granit` (
  `idgranit` int(10) NOT NULL AUTO_INCREMENT,
  `designation` varchar(20) NOT NULL,
  `prix_2cm` varchar(20) NOT NULL,
  `prix_3cm` varchar(20) NOT NULL,
  PRIMARY KEY (`idgranit`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `granit`
--

INSERT INTO `granit` (`idgranit`, `designation`, `prix_2cm`, `prix_3cm`) VALUES
(1, 'noir galaxy', '10,000', '12,000'),
(2, 'rose poinino', '10,000', '12,000'),
(3, 'gris messi', '10,000', '12,000'),
(4, 'créme julia', '13,000', '15,000'),
(5, 'grais', '9,000', '8,500');

-- --------------------------------------------------------

--
-- Structure de la table `marbre`
--

DROP TABLE IF EXISTS `marbre`;
CREATE TABLE IF NOT EXISTS `marbre` (
  `id_marbre` int(10) NOT NULL AUTO_INCREMENT,
  `libele` varchar(20) NOT NULL,
  `prix_2cm` varchar(20) NOT NULL,
  `prix_3cm` varchar(20) NOT NULL,
  PRIMARY KEY (`id_marbre`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `marbre`
--

INSERT INTO `marbre` (`id_marbre`, `libele`, `prix_2cm`, `prix_3cm`) VALUES
(1, 'tala', '10,000', '12,000'),
(2, 'tala gris', '10,000', '12,000'),
(3, 'chevreuné', '10,000', '12,000'),
(4, 'noir azziza', '10,000', '12,000'),
(5, 'gris foussena', '10,000', '12,000'),
(6, 'rose sidibou', '10000', '12000'),
(7, 'blanc italie', '10,000', '12,000'),
(8, 'blanc gréce', '10,000', '12,000'),
(9, 'blanc turkie', '10,000', '12,000');

-- --------------------------------------------------------

--
-- Structure de la table `typemarbre`
--

DROP TABLE IF EXISTS `typemarbre`;
CREATE TABLE IF NOT EXISTS `typemarbre` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typemarbre`
--

INSERT INTO `typemarbre` (`id`, `type`) VALUES
(1, 'Marbre'),
(2, 'Granit');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `login` varchar(20) NOT NULL,
  `mdp` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `login`, `mdp`) VALUES
(1, 'admin', 'admin');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
