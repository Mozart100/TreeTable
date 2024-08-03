import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core'
import { Tree } from "../Models/node"

@Injectable({
  providedIn: 'root'
})
export class TreeTableControllerService {

  private serverUrl: string = ""

  constructor(private httpClient: HttpClient,) {
    this.serverUrl = "https://localhost:7048/api/TreeTable/regions"
  }

  getTreeTable(): Promise<Tree> {
    return Promise.resolve(TreeTableControllerService.mockResponse())
    // return firstValueFrom(this.httpClient.get<Tree>(this.serverUrl))
  }

  private static mockResponse(): Tree {
    return {
      "roots": [
        {
          "nodeType": "Tag",
          "description": "region",
          "stats": [],
          "children": [
            {
              "nodeType": "Label",
              "description": "North",
              "stats": [
                {
                  "value": 10
                },
                {
                  "value": 20
                },
                {
                  "value": 30
                }
              ],
              "children": [
                {
                  "nodeType": "Data",
                  "description": "Nahariya",
                  "stats": [
                    {
                      "value": 1
                    },
                    {
                      "value": 2
                    },
                    {
                      "value": 3
                    }
                  ],
                  "children": [
                    {
                      "nodeType": "Data",
                      "description": "Comp 1",
                      "stats": [
                        {
                          "value": 34
                        },
                        {
                          "value": 35
                        },
                        {
                          "value": 36
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    },
                    {
                      "nodeType": "Data",
                      "description": "Comp 2",
                      "stats": [
                        {
                          "value": 54
                        },
                        {
                          "value": 55
                        },
                        {
                          "value": 56
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    },
                    {
                      "nodeType": "Data",
                      "description": "Comp 3",
                      "stats": [
                        {
                          "value": 74
                        },
                        {
                          "value": 75
                        },
                        {
                          "value": 76
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    }
                  ],
                  "isSelected": false
                },
                {
                  "nodeType": "Data",
                  "description": "Akko",
                  "stats": [
                    {
                      "value": 3
                    },
                    {
                      "value": 4
                    },
                    {
                      "value": 5
                    }
                  ],
                  "children": [
                    {
                      "nodeType": "Data",
                      "description": "Comp 1",
                      "stats": [
                        {
                          "value": 34
                        },
                        {
                          "value": 35
                        },
                        {
                          "value": 36
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    },
                    {
                      "nodeType": "Data",
                      "description": "Comp 2",
                      "stats": [
                        {
                          "value": 54
                        },
                        {
                          "value": 55
                        },
                        {
                          "value": 56
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    },
                    {
                      "nodeType": "Data",
                      "description": "Comp 3",
                      "stats": [
                        {
                          "value": 74
                        },
                        {
                          "value": 75
                        },
                        {
                          "value": 76
                        }
                      ],
                      "children": [],
                      "isSelected": false
                    }
                  ],
                  "isSelected": false
                }
              ],
              "isSelected": false
            },
            {
              "nodeType": "Label",
              "description": "South",
              "stats": [
                {
                  "value": 100
                },
                {
                  "value": 200
                },
                {
                  "value": 300
                }
              ],
              "children": [
                {
                  "nodeType": "Data",
                  "description": "Beer-Sheva",
                  "stats": [
                    {
                      "value": 10
                    },
                    {
                      "value": 20
                    },
                    {
                      "value": 30
                    }
                  ],
                  "children": [],
                  "isSelected": false
                },
                {
                  "nodeType": "Data",
                  "description": "Gaza",
                  "stats": [
                    {
                      "value": 30
                    },
                    {
                      "value": 40
                    },
                    {
                      "value": 50
                    }
                  ],
                  "children": [],
                  "isSelected": false
                }
              ],
              "isSelected": false
            }
          ],
          "isSelected": false
        },
        {
          "nodeType": "Tag",
          "description": "color",
          "stats": [],
          "children": [
            {
              "nodeType": "Label",
              "description": "red",
              "stats": [
                {
                  "value": 10
                },
                {
                  "value": 20
                },
                {
                  "value": 30
                }
              ],
              "children": [
                {
                  "nodeType": "Data",
                  "description": "Nahariya",
                  "stats": [
                    {
                      "value": 1
                    },
                    {
                      "value": 2
                    },
                    {
                      "value": 3
                    }
                  ],
                  "children": [],
                  "isSelected": false
                }
              ],
              "isSelected": false
            },
            {
              "nodeType": "Label",
              "description": "blue",
              "stats": [
                {
                  "value": 10
                },
                {
                  "value": 20
                },
                {
                  "value": 30
                }
              ],
              "children": [
                {
                  "nodeType": "Data",
                  "description": "Beer-sheva",
                  "stats": [
                    {
                      "value": 1
                    },
                    {
                      "value": 2
                    },
                    {
                      "value": 3
                    }
                  ],
                  "children": [],
                  "isSelected": false
                }
              ],
              "isSelected": false
            }
          ],
          "isSelected": false
        }
      ]
    }
  }
}
