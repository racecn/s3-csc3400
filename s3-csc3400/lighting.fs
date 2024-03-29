#version 330 core
out vec4 FragColor;

in vec3 Normal;
in vec3 Position;

uniform vec3 cameraPos;
uniform samplerCube skybox;

void main()
{    
    vec3 I = normalize(Position - cameraPos);
    vec3 R = reflect(I, normalize(Normal));
    R.y = -R.y; // Invert the y-component of the reflection vector
    FragColor = vec4(texture(skybox, R).rgb, 1.0);
}
