//
// MediaInfoLiveStreamResponse.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct MediaInfoLiveStreamResponse: Codable {

    public var mediaSource: MediaSourceInfo?

    public init(mediaSource: MediaSourceInfo? = nil) {
        self.mediaSource = mediaSource
    }

    public enum CodingKeys: String, CodingKey { 
        case mediaSource = "MediaSource"
    }

}