.thumb
push	{r4-r7,lr}

push	{r0-r7}
mov	r4,r1	@text ID
ldr	r7,table

@check if this is shield or mirror shield
ldr	r0,=#0x050D
cmp	r1,r0
blo	loop
ldr	r0,=#0x050E
cmp	r1,r0
bhi	loop

@check if we already set the first small shield text
ldr	r0,=#0x2002EA4
ldr	r1,=#23
ldr	r3,=#0x801D5E0	@vanilla flag check routine
mov	lr,r3
.short	0xF800
cmp	r0,#0
beq	loop

@set the new flag
ldr	r0,=#0x2002EA4
mov	r1,#30
ldr	r3,=#0x801D5F4	@vanilla flag set routine
mov	lr,r3
.short	0xF800

@check text id, compare it to the table
loop:
ldrh	r0,[r7]
cmp	r0,#0
beq	done
cmp	r0,r4
beq	match
next:
add	r7,#8
b	loop

match:
ldr	r0,[r7,#4]	@base offset
ldrh	r1,[r7,#2]	@flag id to set
ldr	r3,=#0x801D5F4	@vanilla flag set routine
mov	lr,r3
.short	0xF800
b	next

done:
pop	{r0-r7}

@and return to the original routine
mov	r7,r0
mov	r3,r1
strh	r3,[r7,#8]
mov	r0,#0x80
push	{r3}
ldr	r3,=#0x805E946
mov	lr,r3
pop	{r3}
.short	0xF800

.align
.ltorg
table:
