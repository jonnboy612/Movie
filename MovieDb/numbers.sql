CREATE TABLE IF NOT EXISTS ingredients (
   `id` 							BIGINT AUTO_INCREMENT
	,`movie_id` 					BIGINT NOT NULL
    ,`release_date` 				DATETIME
	,`runtime`   					TIME 
	,`rating`                       TEXT
    ,`created_by` 					BIGINT NOT NULL DEFAULT 1
	,`created_date` 				DATETIME DEFAULT CURRENT_TIMESTAMP
	,`updated_by` 					BIGINT NOT NULL DEFAULT 1
	,`updated_date` 				DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
	,`is_deleted` 					BOOLEAN DEFAULT FALSE
	,PRIMARY KEY (id)
	,CONSTRAINT fk_movie_numbers FOREIGN KEY (movie_id) REFERENCES movie(id)
);
