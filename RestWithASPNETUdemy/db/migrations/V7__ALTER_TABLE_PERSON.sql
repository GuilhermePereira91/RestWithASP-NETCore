alter table person
	ADD COLUMN `enabled` BIT(1) NOT NULL default 1 AFTER `gender`;
