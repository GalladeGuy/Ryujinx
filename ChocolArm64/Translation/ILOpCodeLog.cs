namespace ChocolArm64.Translation
{
    struct ILOpCodeLog : IILEmit
    {
        private string _text;

        public ILOpCodeLog(string text)
        {
            _text = text;
        }

        public void Emit(ILEmitter context)
        {
            context.Generator.EmitWriteLine(_text);
        }
    }
}