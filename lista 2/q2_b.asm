.data

.text
	move $s1, $zero
	move $s2, $zero
	move $s3, $zero
	move $s4, $zero
	
	addi $s1, $s1, 1
	addi $s2, $s2, 2
	addi $s3, $s3, 3
	
	for:
		add $s3, $s1, $s2 #c = a + b
		addi $s4, $s4, 1
		beq $s4, 10, fimDoFor
		
	fimDoFor:
