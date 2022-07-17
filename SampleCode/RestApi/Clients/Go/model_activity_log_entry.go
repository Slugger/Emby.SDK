/*
 * Emby REST API
 *
 * Explore the Emby Server API
 *
 */
package embyclient-rest-go
import (
	"time"
)

type ActivityLogEntry struct {
	Id int64 `json:"Id,omitempty"`
	Name string `json:"Name,omitempty"`
	Overview string `json:"Overview,omitempty"`
	ShortOverview string `json:"ShortOverview,omitempty"`
	Type_ string `json:"Type,omitempty"`
	ItemId string `json:"ItemId,omitempty"`
	Date time.Time `json:"Date,omitempty"`
	UserId string `json:"UserId,omitempty"`
	UserPrimaryImageTag string `json:"UserPrimaryImageTag,omitempty"`
	Severity *LoggingLogSeverity `json:"Severity,omitempty"`
}