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

type DevicesDeviceInfo struct {
	Name string `json:"Name,omitempty"`
	Id string `json:"Id,omitempty"`
	LastUserName string `json:"LastUserName,omitempty"`
	AppName string `json:"AppName,omitempty"`
	AppVersion string `json:"AppVersion,omitempty"`
	LastUserId string `json:"LastUserId,omitempty"`
	DateLastActivity time.Time `json:"DateLastActivity,omitempty"`
	IconUrl string `json:"IconUrl,omitempty"`
}