export class TransactData {
  amount: string = ""
  date: Date = new Date()
  esIncidencia: boolean = false
  isAlert: boolean = false
  message: string = ""
  numLinea: number = 0
  type: string = ""
  isCorrect = !this.esIncidencia && !this.isAlert
}
