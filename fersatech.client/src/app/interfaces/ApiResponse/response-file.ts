import { TransactData } from "./transact-data"
import { UploadSummary } from "./upload-summary"

export class ResponseFile {
  code: number = 0
  message: string = ""
  result: UploadSummary = new UploadSummary()
  data: TransactData[] = []
}
