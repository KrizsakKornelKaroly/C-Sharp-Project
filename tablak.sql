CREATE TABLE IF NOT EXISTS `helyszin` (
	`helyszin_id` int AUTO_INCREMENT NOT NULL,
	`megnev` varchar(255) NOT NULL,
	`cim` varchar(255) NOT NULL,
	`kapacitas` int NOT NULL,
	PRIMARY KEY (`helyszin_id`)
);

CREATE TABLE IF NOT EXISTS `esemeny` (
	`esemeny_id` int AUTO_INCREMENT NOT NULL,
	`nev` varchar(255) NOT NULL,
	`idopont` datetime NOT NULL,
	`helyszin_id` int NOT NULL,
	PRIMARY KEY (`esemeny_id`)
);

CREATE TABLE IF NOT EXISTS `jegy` (
	`jegytipus` varchar(255) NOT NULL,
	`jegyar` int NOT NULL,
	`esemeny_id` int NOT NULL,
	`mennyiseg` int NOT NULL,
	`jegy_id` int AUTO_INCREMENT NOT NULL,
	PRIMARY KEY (`jegy_id`)
);


ALTER TABLE `esemeny` ADD CONSTRAINT `esemeny_fk3` FOREIGN KEY (`helyszin_id`) REFERENCES `helyszin`(`helyszin_id`);
ALTER TABLE `jegy` ADD CONSTRAINT `jegy_fk2` FOREIGN KEY (`esemeny_id`) REFERENCES `esemeny`(`esemeny_id`);