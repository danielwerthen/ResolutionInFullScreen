uniform int WIDTH;
uniform int HEIGHT;

void main(void)
{
	if (gl_FragCoord.x > float(WIDTH - 10))
	{
		gl_FragColor = vec4 (1,1,1,1);
	}
	else if (gl_FragCoord.y > float(HEIGHT - 10))
	{
		gl_FragColor = vec4 (1,1,1,1);
	}
	else 
	{
		gl_FragColor = vec4 (0,0,0,0);
	}
}