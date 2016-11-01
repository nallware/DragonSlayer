namespace DragonSlayer
{

    public class UserMessage
    {
        private bool success;
        private int records;
        private int quantity;
        private string error;
        private string errorType;
        private string exception;
        private string exceptionType;
        private string status;
        private string instruction;
        private string alert;
        private string message;
        private string messageType;
        private string entity;
        private string entityType;
        private string process;
        private string processType;

        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

        public int Records
        {
            get { return records; }
            set { records = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public string ErrorType
        {
            get { return errorType; }
            set { errorType = value; }
        }

        public string Exception
        {
            get { return exception; }
            set { exception = value; }
        }

        public string ExceptionType
        {
            get { return exceptionType; }
            set { exceptionType = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Instruction
        {
            get { return instruction; }
            set { instruction = value; }
        }

        public string Alert
        {
            get { return alert; }
            set { alert = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string MessageType
        {
            get { return messageType; }
            set { messageType = value; }
        }
        public string Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public string EntityType
        {
            get { return entityType; }
            set { entityType = value; }
        }

        public string Process
        {
            get { return process; }
            set { process = value; }
        }

        public string ProcessType
        {
            get { return processType; }
            set { processType = value; }
        }

        public bool isEmpty()
        {
            bool empty = true;

            foreach (var prop in this.GetType().GetProperties())
            {
                if (prop.ToString() != "")
                {
                    empty = false;
                }

            }
            return empty;
        }
    }
}

