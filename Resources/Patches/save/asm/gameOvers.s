.thumb
push	{r0-r7}
ldr	r1,=#0x203FE00
ldrh	r2,[r1,#4]
ldr	r3,=#10000
cmp	r2,r3
beq	end
add	r2,#1
strh	r2,[r1,#4]
ldr	r2,=#0x2000004
ldrb	r2,[r2]
ldr	r0,=#0x500
mul	r2,r0
ldr	r3,=#0xE001F00
add	r2,r3
ldrb	r0,[r1,#4]
strb	r0,[r2,#4]
ldrb	r0,[r1,#5]
strb	r0,[r2,#5]
end:
pop	{r0-r7}
push	{lr}
mov	r0,#7
mov	r1,#8
ldr	r3,=#0x804FC90
mov	lr,r3
.short	0xF800
push	{r3}
ldr	r3,=#0x8051962
mov	lr,r3
pop	{r3}
.short	0xF800
