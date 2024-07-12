CREATE DATABASE db_MirellasStore;

CREATE TABLE cliente (
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    nome VARCHAR (100) NOT NULL);
    
CREATE TABLE produto (
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	nome VARCHAR (100) NOT NULL,
	quantidade INT NOT NULL,
	preco DOUBLE NOT NULL,
    peso DOUBLE NOT NULL,
    marca VARCHAR (100) NOT NULL);
    
CREATE TABLE compra (
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    distancia DOUBLE NOT NULL,
    id_produto INT NOT NULL,
    id_cliente INT NOT NULL);
    
ALTER TABLE compra
ADD FOREIGN KEY (id_produto)
REFERENCES produto (id);

ALTER TABLE compra
ADD FOREIGN KEY (id_cliente)
REFERENCES cliente (id);

    
INSERT INTO cliente (nome) 
	VALUES 
		('José Luis'),
		('Fernando Sousa'),
		('Mario Oliveira');
        

INSERT INTO produto (nome, quantidade, preco, peso, marca) 
	VALUES 
		('Fone de Ouvido', '2', '150.00', '30.00', 'JBL'),
		('Teclado', '6', '80.00', '300.00', 'Positivo'),
        ('Mouse', '4', '50.00', '80.00', 'Asus');
		
INSERT INTO compra (distancia, id_produto, id_cliente) 
	VALUES 
		('495.00', 1, 3 ),
		('558.00', 2, 2 ),
        ('780.00', 3, 1 );
        
SELECT * FROM produto 
JOIN compra 
ON produto.id = compra.id_produto
JOIN cliente
ON cliente.id = compra.id_cliente;

TRUNCATE TABLE cliente;
SELECT * FROM compra;
        
    
