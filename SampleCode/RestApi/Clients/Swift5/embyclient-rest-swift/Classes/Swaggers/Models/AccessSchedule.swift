//
// AccessSchedule.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct AccessSchedule: Codable {

    public var dayOfWeek: DynamicDayOfWeek?
    /** The start hour. */
    public var startHour: Double?
    /** The end hour. */
    public var endHour: Double?

    public init(dayOfWeek: DynamicDayOfWeek? = nil, startHour: Double? = nil, endHour: Double? = nil) {
        self.dayOfWeek = dayOfWeek
        self.startHour = startHour
        self.endHour = endHour
    }

    public enum CodingKeys: String, CodingKey { 
        case dayOfWeek = "DayOfWeek"
        case startHour = "StartHour"
        case endHour = "EndHour"
    }

}