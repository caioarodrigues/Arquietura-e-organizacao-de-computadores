.data
		
.text
	move $s1, $zero
	move $s2, $zero
	move $s3, $zero
	
	addi $s1, $s1, 1
	addi $s2, $s2, 2
	addi $s3, $s3, 3
	
	while: 
		beq $s1, 0, saida #se a != 0
		add $s3, $s1, $s2 #c = a + b
		subi $s1, $s1, 1 #a = a--
		j while 
	saida:  
