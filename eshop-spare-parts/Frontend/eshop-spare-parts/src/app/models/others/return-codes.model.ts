export class ReturnCodes {
    public static get Ok(): number { return 200; };

    public static get Created(): number { return 201; };

    public static get BadRequest(): number { return 400; };

    public static get Unauthorized(): number { return 401; };

    public static get Forbidden(): number { return 403; };

    public static get NotFound(): number { return 404; };
  }