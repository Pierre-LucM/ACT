﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
namespace _Scripts._Version_1._0.Services.RoomServices.WoZRoomService
{
    
    public struct AvatarHeadMoveData
    {
        public double x;
        public double y;
        public double z;
    }
    public class WoZRoomService:AbstractRoomServices
    {
        
        
        public void OnAvatarHeadMove (AvatarHeadMoveData data)
        {
            AvatarHeadMoveData avatarHeadMoveData = data;
            MainManager.Instance.HeadPoseController.HeadPoseUpdateByValue(avatarHeadMoveData.x, avatarHeadMoveData.y, avatarHeadMoveData.z);
        }
        public void OnAvatarBlendshapeMove(Dictionary<string,double> data)
        {
            Dictionary<string,double> avatarBlendshapeData = data;
            MainManager.Instance.BlendShapesController.ChangeBlendShapesByDict(avatarBlendshapeData);
        }
        public void OnBlendshapesTransition(Dictionary<string,double> data, float duration)
        {
            Dictionary<string,double> avatarBlendshapeData = data;
           MainManager.Instance.BlendShapesController.TransitionToDict(avatarBlendshapeData, duration);
        }

        public void OnAvatarPoseTransition(Vector3 data, float duration)
        {
            MainManager.Instance.HeadPoseController.MakeRotTransition(data, duration);
        }
        
        
        public void OnRoomJoined(string data)
        {
            
        }
        

        
    }
}