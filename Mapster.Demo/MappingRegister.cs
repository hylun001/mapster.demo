namespace Mapster.Demo
{
    /// <summary>
    /// 对象映射配置
    /// </summary>
    public class MappingRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<Student, StudentDto>()
             .Map(dto => dto.CourceName, s => s.Cource.CourceName)
             .Map(dto => dto.Grade, s => s.Cource.Grade);
        }
    }
}
