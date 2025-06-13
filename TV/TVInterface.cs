using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200019A RID: 410
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x060020F1 RID: 8433 RVA: 0x000D9EAC File Offset: 0x000D80AC
		// Note: this type is marked as 'beforefieldinit'.
		static TVInterface()
		{
			Il2CppClassPointerStore<TVInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVInterface>.NativeClassPtr);
			TVInterface.NativeFieldInfoPtr_OPEN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "OPEN_TIME");
			TVInterface.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "FOV");
			TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			TVInterface.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Players");
			TVInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Canvas");
			TVInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "CameraPosition");
			TVInterface.NativeFieldInfoPtr_HomeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "HomeScreen");
			TVInterface.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "TimeLabel");
			TVInterface.NativeFieldInfoPtr_Daylabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Daylabel");
			TVInterface.NativeFieldInfoPtr_onPlayerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerAdded");
			TVInterface.NativeFieldInfoPtr_onPlayerRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerRemoved");
			TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667013);
			TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667014);
			TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667015);
			TVInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667016);
			TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667017);
			TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667018);
			TVInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667019);
			TVInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667020);
			TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667021);
			TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667022);
			TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667023);
			TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667024);
			TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100667025);
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x000DA0BC File Offset: 0x000D82BC
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x000DA0F8 File Offset: 0x000D82F8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000DA138 File Offset: 0x000D8338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112466, XrefRangeEnd = 112485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000DA16C File Offset: 0x000D836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112485, XrefRangeEnd = 112496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000DA1A0 File Offset: 0x000D83A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112496, XrefRangeEnd = 112514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000DA1D4 File Offset: 0x000D83D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112525, RefRangeEnd = 112526, XrefRangeStart = 112514, XrefRangeEnd = 112525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000DA208 File Offset: 0x000D8408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112587, RefRangeEnd = 112588, XrefRangeStart = 112526, XrefRangeEnd = 112587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000DA23C File Offset: 0x000D843C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112641, RefRangeEnd = 112643, XrefRangeStart = 112588, XrefRangeEnd = 112641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000DA270 File Offset: 0x000D8470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112643, XrefRangeEnd = 112645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000DA2B4 File Offset: 0x000D84B4
		[CallerCount(0)]
		public unsafe bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000DA2F0 File Offset: 0x000D84F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112645, XrefRangeEnd = 112656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000DA334 File Offset: 0x000D8534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112656, XrefRangeEnd = 112665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000DA378 File Offset: 0x000D8578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112665, XrefRangeEnd = 112685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVInterface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00012713 File Offset: 0x00010913
		public TVInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x000DA3B4 File Offset: 0x000D85B4
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0001271C File Offset: 0x0001091C
		public unsafe static float OPEN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x000DA3D0 File Offset: 0x000D85D0
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0001272A File Offset: 0x0001092A
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x000DA3EC File Offset: 0x000D85EC
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x00012738 File Offset: 0x00010938
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000DA414 File Offset: 0x000D8614
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00012753 File Offset: 0x00010953
		public unsafe List<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000DA444 File Offset: 0x000D8644
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x00012772 File Offset: 0x00010972
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000DA474 File Offset: 0x000D8674
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x00012791 File Offset: 0x00010991
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000DA4A4 File Offset: 0x000D86A4
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x000127B0 File Offset: 0x000109B0
		public unsafe TVHomeScreen HomeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000DA4D4 File Offset: 0x000D86D4
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x000127CF File Offset: 0x000109CF
		public unsafe TextMeshPro TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000DA504 File Offset: 0x000D8704
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x000127EE File Offset: 0x000109EE
		public unsafe TextMeshPro Daylabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000DA534 File Offset: 0x000D8734
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0001280D File Offset: 0x00010A0D
		public unsafe UnityEvent<Player> onPlayerAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x000DA564 File Offset: 0x000D8764
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0001282C File Offset: 0x00010A2C
		public unsafe UnityEvent<Player> onPlayerRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeFieldInfoPtr_OPEN_TIME;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeFieldInfoPtr_HomeScreen;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeFieldInfoPtr_Daylabel;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerAdded;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerRemoved;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Public_Boolean_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
