export async function fetchRaceEvents(): Promise<RaceEvent[]> {
  const response = await fetch('http://localhost:5275/RaceEvent')

  if (!response.ok) {
    throw new Error('OH NO! Panic')
  }

  const jsonData = await response.json()
  const rawEvents = (Array.isArray(jsonData)
    ? jsonData
    : (jsonData?.data ?? jsonData?.value ?? [])) as RawRaceEvent[]

  return rawEvents.map((item) => ({
    EventName: item.eventName,
    Series: item.series,
    StartTime: item.startTime,
    Track: {
      Country: item.track.country,
      Name: item.track.name,
    },
  }))
}

export interface RaceEvent {
  EventName: string
  Series: string
  StartTime: string
  Track: Track
}

interface RawRaceEvent {
  eventName: string
  series: string
  startTime: string
  track: RawTrack
}

interface RawTrack {
  country: string
  name: string
}

export interface Track {
  Country: string
  Name: string
}

// export { fetchRaceEvents }
