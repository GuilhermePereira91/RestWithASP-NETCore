CREATE TABLE IF NOT EXISTS `rest_with_asp_net_udemy`.`person` (
  `id` BIGINT(20) NOT NULL AUTO_INCREMENT,
  `address` VARCHAR(100) NOT NULL,
  `first_name` VARCHAR(80) NOT NULL,
  `gender` VARCHAR(6) NOT NULL,
  `last_name` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`id`));