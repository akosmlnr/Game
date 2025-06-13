using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000195 RID: 405
	public class Snake : TVApp
	{
		// Token: 0x0600204A RID: 8266 RVA: 0x000D7F0C File Offset: 0x000D610C
		// Note: this type is marked as 'beforefieldinit'.
		static Snake()
		{
			Il2CppClassPointerStore<Snake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Snake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snake>.NativeClassPtr);
			Snake.NativeFieldInfoPtr_SIZE_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_X");
			Snake.NativeFieldInfoPtr_SIZE_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_Y");
			Snake.NativeFieldInfoPtr_TilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TilePrefab");
			Snake.NativeFieldInfoPtr_TimePerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TimePerTile");
			Snake.NativeFieldInfoPtr_PlaySpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "PlaySpace");
			Snake.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "Tiles");
			Snake.NativeFieldInfoPtr_ScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "ScoreText");
			Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<HeadPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Tail_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Tail>k__BackingField");
			Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<LastTailPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Direction>k__BackingField");
			Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<QueuedDirection>k__BackingField");
			Snake.NativeFieldInfoPtr__NextDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<NextDirection>k__BackingField");
			Snake.NativeFieldInfoPtr_lastFoodPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "lastFoodPosition");
			Snake.NativeFieldInfoPtr__GameState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<GameState>k__BackingField");
			Snake.NativeFieldInfoPtr__timeSinceLastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeSinceLastMove");
			Snake.NativeFieldInfoPtr__timeOnGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeOnGameOver");
			Snake.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onStart");
			Snake.NativeFieldInfoPtr_onEat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onEat");
			Snake.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onGameOver");
			Snake.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onWin");
			Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666946);
			Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666947);
			Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666948);
			Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666949);
			Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666950);
			Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666951);
			Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666952);
			Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666953);
			Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666954);
			Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666955);
			Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666956);
			Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666957);
			Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666958);
			Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666959);
			Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666960);
			Snake.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666961);
			Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666962);
			Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666963);
			Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666964);
			Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666965);
			Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666966);
			Snake.NativeMethodInfoPtr_Eat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666967);
			Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666968);
			Snake.NativeMethodInfoPtr_GameOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666969);
			Snake.NativeMethodInfoPtr_Win_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666970);
			Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666971);
			Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666972);
			Snake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666973);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x000D8310 File Offset: 0x000D6510
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x000D834C File Offset: 0x000D654C
		public unsafe Vector2 HeadPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000D838C File Offset: 0x000D658C
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x000D83CC File Offset: 0x000D65CC
		public unsafe List<Vector2> Tail
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112012, XrefRangeEnd = 112013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000D8410 File Offset: 0x000D6610
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x000D844C File Offset: 0x000D664C
		public unsafe Vector2 LastTailPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000D848C File Offset: 0x000D668C
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x000D84C8 File Offset: 0x000D66C8
		public unsafe Vector2 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x000D8508 File Offset: 0x000D6708
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x000D8544 File Offset: 0x000D6744
		public unsafe Vector2 QueuedDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x000D8584 File Offset: 0x000D6784
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x000D85C0 File Offset: 0x000D67C0
		public unsafe Vector2 NextDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x000D8600 File Offset: 0x000D6800
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x000D863C File Offset: 0x000D683C
		public unsafe Snake.EGameState GameState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 52321, RefRangeEnd = 52327, XrefRangeStart = 52321, XrefRangeEnd = 52327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000D867C File Offset: 0x000D687C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112013, XrefRangeEnd = 112014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000D86B8 File Offset: 0x000D68B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112014, XrefRangeEnd = 112021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000D86EC File Offset: 0x000D68EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112062, RefRangeEnd = 112063, XrefRangeStart = 112021, XrefRangeEnd = 112062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000D8720 File Offset: 0x000D6920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112063, XrefRangeEnd = 112065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000D8754 File Offset: 0x000D6954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112076, RefRangeEnd = 112079, XrefRangeStart = 112065, XrefRangeEnd = 112076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveSnake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000D8788 File Offset: 0x000D6988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112079, RefRangeEnd = 112082, XrefRangeStart = 112079, XrefRangeEnd = 112079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile GetTile(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr2) : null;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000D87D4 File Offset: 0x000D69D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112105, RefRangeEnd = 112106, XrefRangeStart = 112082, XrefRangeEnd = 112105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(Vector2 initialDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initialDir;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000D8814 File Offset: 0x000D6A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112106, XrefRangeEnd = 112111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Eat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Eat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000D8848 File Offset: 0x000D6A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112128, RefRangeEnd = 112129, XrefRangeStart = 112111, XrefRangeEnd = 112128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnFood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000D887C File Offset: 0x000D6A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112129, XrefRangeEnd = 112130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GameOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000D88B0 File Offset: 0x000D6AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112130, XrefRangeEnd = 112131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Win_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000D88E4 File Offset: 0x000D6AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112131, XrefRangeEnd = 112133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000D8920 File Offset: 0x000D6B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112133, XrefRangeEnd = 112154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000D8954 File Offset: 0x000D6B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112154, XrefRangeEnd = 112172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Snake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Snake>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00012194 File Offset: 0x00010394
		public Snake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x000D8990 File Offset: 0x000D6B90
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x0001219D File Offset: 0x0001039D
		public unsafe static int SIZE_X
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x000D89AC File Offset: 0x000D6BAC
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x000121AB File Offset: 0x000103AB
		public unsafe static int SIZE_Y
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000D89C8 File Offset: 0x000D6BC8
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x000121B9 File Offset: 0x000103B9
		public unsafe SnakeTile TilePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000D89F8 File Offset: 0x000D6BF8
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x000121D8 File Offset: 0x000103D8
		public unsafe float TimePerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile)) = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x000D8A20 File Offset: 0x000D6C20
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x000121F3 File Offset: 0x000103F3
		public unsafe RectTransform PlaySpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000D8A50 File Offset: 0x000D6C50
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00012212 File Offset: 0x00010412
		public unsafe Il2CppReferenceArray<SnakeTile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SnakeTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000D8A80 File Offset: 0x000D6C80
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00012231 File Offset: 0x00010431
		public unsafe TextMeshProUGUI ScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x000D8AB0 File Offset: 0x000D6CB0
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00012250 File Offset: 0x00010450
		public unsafe Vector2 _HeadPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x000D8AD8 File Offset: 0x000D6CD8
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x0001226B File Offset: 0x0001046B
		public unsafe List<Vector2> _Tail_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000D8B08 File Offset: 0x000D6D08
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x0001228A File Offset: 0x0001048A
		public unsafe Vector2 _LastTailPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x000D8B30 File Offset: 0x000D6D30
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x000122A5 File Offset: 0x000104A5
		public unsafe Vector2 _Direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x000D8B58 File Offset: 0x000D6D58
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x000122C0 File Offset: 0x000104C0
		public unsafe Vector2 _QueuedDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x000D8B80 File Offset: 0x000D6D80
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x000122DB File Offset: 0x000104DB
		public unsafe Vector2 _NextDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000D8BA8 File Offset: 0x000D6DA8
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x000122F6 File Offset: 0x000104F6
		public unsafe Vector2 lastFoodPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition)) = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000D8BD0 File Offset: 0x000D6DD0
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x00012311 File Offset: 0x00010511
		public unsafe Snake.EGameState _GameState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x000D8BF8 File Offset: 0x000D6DF8
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x0001232C File Offset: 0x0001052C
		public unsafe float _timeSinceLastMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove)) = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x000D8C20 File Offset: 0x000D6E20
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x00012347 File Offset: 0x00010547
		public unsafe float _timeOnGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver)) = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x000D8C48 File Offset: 0x000D6E48
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x00012362 File Offset: 0x00010562
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x000D8C78 File Offset: 0x000D6E78
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x00012381 File Offset: 0x00010581
		public unsafe UnityEvent onEat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x000D8CA8 File Offset: 0x000D6EA8
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x000123A0 File Offset: 0x000105A0
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x000D8CD8 File Offset: 0x000D6ED8
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x000123BF File Offset: 0x000105BF
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_X;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_Y;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_TilePrefab;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_TimePerTile;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr_PlaySpace;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr_ScoreText;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr__HeadPosition_k__BackingField;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr__Tail_k__BackingField;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr__LastTailPosition_k__BackingField;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeFieldInfoPtr__Direction_k__BackingField;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeFieldInfoPtr__QueuedDirection_k__BackingField;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeFieldInfoPtr__NextDirection_k__BackingField;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeFieldInfoPtr_lastFoodPosition;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeFieldInfoPtr__GameState_k__BackingField;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastMove;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr__timeOnGameOver;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_onEat;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Private_Void_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_MoveSnake_Private_Void_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_Void_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_SpawnFood_Private_Void_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_GameOver_Private_Void_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_CreateTiles_Public_Void_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008E6 RID: 2278
		[OriginalName("Assembly-CSharp.dll", "", "EGameState")]
		public enum EGameState
		{
			// Token: 0x0400875B RID: 34651
			Ready,
			// Token: 0x0400875C RID: 34652
			Playing
		}
	}
}
