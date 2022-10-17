namespace ConsoleProject.Default.EnumList {
    export enum Department {
        Science = 1,
        Commerce = 2,
        Arts = 3
    }
    Serenity.Decorators.registerEnumType(Department, 'ConsoleProject.Default.EnumList.Department', 'Department');
}

