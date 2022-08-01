.data
	msg1: .asciiz "N: "
	msg2: .asciiz "Soma = "

.text
	li $v0, 4 
	la $a0, msg1 #chama msg1
	syscall

	#pedindo o valor de N:
	li $v0, 5
	syscall
	move $t0, $v0
	
	#inicializando os registradores:
	li $t1, 0 #contador
	li $t2, 0 #soma

	loop: 
		addi $t1, $t1, 1 #i++
		add $t2, $t2, $t1 #s += i
		beq $t0, $t1, saida # i == cont ? (continue : saida)
		j loop

	saida:
		li $v0, 4
		la $a0, msg2
		syscall
		
		li $v0, 1
		move $a0, $t2
		syscall
