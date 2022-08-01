.data
	msg1: .asciiz "Digite o valor de x: "
	msg2: .asciiz "y = "
	newline: .asciiz "\n"
.text
	main:
		li $v0, 4 
		la $a0, msg1 #chama msg1
		syscall
		
		li	$v0,5		
		syscall	
		move	$t0,$v0	# resultado do syscall retorna em $v0, ler o valor de x
		
		li $v0, 4
		la $a0, newline
		syscall
		
		j function
		
	function:
		li $t1, 3
		li $t2, 5
		mul $s0, $t0, $t1 # a = a * 3
		add $s0, $s0, $t2 # a = a + 5
		
		j fimFunction
		
	fimFunction:
		
	li $v0, 4
	la $a0, msg2
	syscall
	
	li $v0, 1
	move $a0, $s0
	syscall
