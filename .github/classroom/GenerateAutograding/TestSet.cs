﻿namespace GenerateAutograding;

internal sealed class TestSet
{
    private readonly string _startupProject;

    public TestSet(string startupProject) => _startupProject = startupProject;

    public IReadOnlyList<Test> Tests => new Test[]
    {
        
        new DotnetTestGroup("AutoList_AddFiveBrands")
        {
            Points = 100
        },
    };
}