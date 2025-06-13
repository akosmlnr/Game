using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using Il2CppSteamworks;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Multiplayer
{
	// Token: 0x020006DC RID: 1756
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		// Token: 0x06009D8A RID: 40330 RVA: 0x00281FE0 File Offset: 0x002801E0
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInterface()
		{
			Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Multiplayer", "LobbyInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
			LobbyInterface.NativeFieldInfoPtr_Lobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Lobby");
			LobbyInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Canvas");
			LobbyInterface.NativeFieldInfoPtr_LobbyTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LobbyTitle");
			LobbyInterface.NativeFieldInfoPtr_PlayerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "PlayerSlots");
			LobbyInterface.NativeFieldInfoPtr_InviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteButton");
			LobbyInterface.NativeFieldInfoPtr_LeaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LeaveButton");
			LobbyInterface.NativeFieldInfoPtr_InviteHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteHint");
			LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682770);
			LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682771);
			LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682772);
			LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682773);
			LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682774);
			LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682775);
			LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682776);
			LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682777);
			LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682778);
			LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682779);
			LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682780);
			LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682781);
			LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682782);
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x002821A0 File Offset: 0x002803A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279880, XrefRangeEnd = 279921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x002821DC File Offset: 0x002803DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279921, XrefRangeEnd = 279944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x00282218 File Offset: 0x00280418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279944, XrefRangeEnd = 279952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x0028224C File Offset: 0x0028044C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279952, XrefRangeEnd = 279954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x0028228C File Offset: 0x0028048C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279954, XrefRangeEnd = 279956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x002822C0 File Offset: 0x002804C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279956, XrefRangeEnd = 279962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InviteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x002822F4 File Offset: 0x002804F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279971, RefRangeEnd = 279973, XrefRangeStart = 279962, XrefRangeEnd = 279971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x00282328 File Offset: 0x00280528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279991, RefRangeEnd = 279993, XrefRangeStart = 279973, XrefRangeEnd = 279991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x0028235C File Offset: 0x0028055C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280005, RefRangeEnd = 280007, XrefRangeStart = 279993, XrefRangeEnd = 280005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayer(int index, CSteamID player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref player;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x002823A8 File Offset: 0x002805A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280015, RefRangeEnd = 280016, XrefRangeStart = 280007, XrefRangeEnd = 280015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x002823E8 File Offset: 0x002805E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280032, RefRangeEnd = 280033, XrefRangeStart = 280016, XrefRangeEnd = 280032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetAvatar(CSteamID user)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref user;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x00282434 File Offset: 0x00280634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280033, XrefRangeEnd = 280036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x00282470 File Offset: 0x00280670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280036, XrefRangeEnd = 280056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x0004CE99 File Offset: 0x0004B099
		public LobbyInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009D99 RID: 40345 RVA: 0x002824A4 File Offset: 0x002806A4
		// (set) Token: 0x06009D9A RID: 40346 RVA: 0x0004CEA2 File Offset: 0x0004B0A2
		public unsafe Lobby Lobby
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x002824D4 File Offset: 0x002806D4
		// (set) Token: 0x06009D9C RID: 40348 RVA: 0x0004CEC1 File Offset: 0x0004B0C1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x00282504 File Offset: 0x00280704
		// (set) Token: 0x06009D9E RID: 40350 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
		public unsafe TextMeshProUGUI LobbyTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x00282534 File Offset: 0x00280734
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x0004CEFF File Offset: 0x0004B0FF
		public unsafe Il2CppReferenceArray<RectTransform> PlayerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x00282564 File Offset: 0x00280764
		// (set) Token: 0x06009DA2 RID: 40354 RVA: 0x0004CF1E File Offset: 0x0004B11E
		public unsafe Button InviteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x00282594 File Offset: 0x00280794
		// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x0004CF3D File Offset: 0x0004B13D
		public unsafe Button LeaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x002825C4 File Offset: 0x002807C4
		// (set) Token: 0x06009DA6 RID: 40358 RVA: 0x0004CF5C File Offset: 0x0004B15C
		public unsafe GameObject InviteHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069F0 RID: 27120
		private static readonly IntPtr NativeFieldInfoPtr_Lobby;

		// Token: 0x040069F1 RID: 27121
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040069F2 RID: 27122
		private static readonly IntPtr NativeFieldInfoPtr_LobbyTitle;

		// Token: 0x040069F3 RID: 27123
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSlots;

		// Token: 0x040069F4 RID: 27124
		private static readonly IntPtr NativeFieldInfoPtr_InviteButton;

		// Token: 0x040069F5 RID: 27125
		private static readonly IntPtr NativeFieldInfoPtr_LeaveButton;

		// Token: 0x040069F6 RID: 27126
		private static readonly IntPtr NativeFieldInfoPtr_InviteHint;

		// Token: 0x040069F7 RID: 27127
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040069F8 RID: 27128
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040069F9 RID: 27129
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040069FA RID: 27130
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040069FB RID: 27131
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClicked_Public_Void_0;

		// Token: 0x040069FC RID: 27132
		private static readonly IntPtr NativeMethodInfoPtr_InviteClicked_Public_Void_0;

		// Token: 0x040069FD RID: 27133
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x040069FE RID: 27134
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayers_Private_Void_0;

		// Token: 0x040069FF RID: 27135
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0;

		// Token: 0x04006A00 RID: 27136
		private static readonly IntPtr NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0;

		// Token: 0x04006A01 RID: 27137
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0;

		// Token: 0x04006A02 RID: 27138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A03 RID: 27139
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
