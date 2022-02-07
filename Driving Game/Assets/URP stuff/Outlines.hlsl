#ifndef OUTLINES_INCLUDED
#define OUTLINES_INCLUDED

#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

struct Attributes
{
    float4 positionOS : POSITION;
    float3 normalOS : NORMAL;
};

struct VertexOutput
{
    float4 positionCS : SV_POSITION;
};

float _Thickness;
float _Colour;

VertexOutput Vertex(Attributes input)
{
    Ver
}
#endif
