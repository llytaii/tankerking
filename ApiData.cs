public class Prices {
	public float diesel {get; set;}
	public float e5 {get; set;}
	public float e10 {get; set;}
	public float e5_ch	{get; set;}
	public float e5_ts	{get; set;}
	public float e10_ch	{get; set;}
	public float e10_ts	{get; set;}
	public float diesel_ch	{get; set;}
	public float diesel_ts	{get; set;}
}

public class Periods {
	public string startp {get; set;}
	public string endp {get; set;}
}

public class OpeningTime {
	public int applicable_days {get; set;}
	public Periods periods {get; set;}
}

public class Station {
	public string id {get; set;}
	public string name {get; set;}
	public string brand {get; set;}
	public string street {get; set;}
	public string house_number {get; set;}
	public int post_code {get; set;}
	public string place {get; set;}
	public float lat {get; set;}
	public float lng {get; set;}
	public float dist {get; set;}
	public int opens {get; set;}
	public Prices prices {get; set;}
	public List<OpeningTime> openingTimes {get; set;}
}

public class Pos {
	public float lat {get; set;}
	public float lng {get; set;}
}

public class ApiData{
	public List<Station> stations {get; set;}
	public Pos pos {get; set;}
	public float dt {get; set;}
}
