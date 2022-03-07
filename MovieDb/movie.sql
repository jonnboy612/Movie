CREATE TABLE IF NOT EXISTS recipes (
   `id` 				    		BIGINT AUTO_INCREMENT
	,`title` 						TEXT
  	,`image` 						TEXT
	,`description` 					TEXT
    ,`created_by` 					BIGINT NOT NULL DEFAULT 1
	,`created_date` 				DATETIME DEFAULT CURRENT_TIMESTAMP
	,`updated_by` 					BIGINT NOT NULL DEFAULT 1
	,`updated_date` 				DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
	,`is_deleted` 					BOOLEAN DEFAULT FALSE
	,PRIMARY KEY (id)
);
