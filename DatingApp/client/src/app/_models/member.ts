import { Photo } from "./photo"

export interface Member {
  id: number
  userName: string
  photoUrl: string
  age: number
  knownAs: string
  created: string
  lastActive: string
  gender: string
  introduction: string
  lookingFor: string
  city: string
  country: string
  interests: string
  photos: Photo[]
}

