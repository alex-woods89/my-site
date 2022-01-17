export class Email {
  constructor(
    public emailBody: string = "",
    public sendersName: string = "",
    public sendersEmailAddress: string = "",
    public subject: string = ""
  ) { }
}
