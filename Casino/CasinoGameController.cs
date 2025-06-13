using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C4 RID: 1220
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x0600691B RID: 26907 RVA: 0x001DA62C File Offset: 0x001D882C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameController()
		{
			Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr);
			CasinoGameController.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "FOV");
			CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "CAMERA_LERP_TIME");
			CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "<IsOpen>k__BackingField");
			CasinoGameController.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Players");
			CasinoGameController.NativeFieldInfoPtr_Interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Interaction");
			CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "DefaultCameraTransforms");
			CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "localDefaultCameraTransform");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676716);
			CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676717);
			CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676718);
			CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676719);
			CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676720);
			CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676721);
			CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676722);
			CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676723);
			CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676724);
			CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676725);
			CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676726);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676727);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676728);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676729);
			CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100676730);
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x001DA83C File Offset: 0x001D8A3C
		// (set) Token: 0x0600691D RID: 26909 RVA: 0x001DA878 File Offset: 0x001D8A78
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x001DA8B8 File Offset: 0x001D8AB8
		public unsafe CasinoGamePlayerData LocalPlayerData
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 213220, RefRangeEnd = 213236, XrefRangeStart = 213214, XrefRangeEnd = 213220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr2) : null;
			}
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x001DA8F8 File Offset: 0x001D8AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213258, RefRangeEnd = 213260, XrefRangeStart = 213236, XrefRangeEnd = 213258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x001DA934 File Offset: 0x001D8B34
		[CallerCount(0)]
		public unsafe virtual void OnLocalPlayerRequestJoin(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x001DA984 File Offset: 0x001D8B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213261, RefRangeEnd = 213262, XrefRangeStart = 213260, XrefRangeEnd = 213261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x001DA9D4 File Offset: 0x001D8BD4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x001DAA10 File Offset: 0x001D8C10
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x001DAA4C File Offset: 0x001D8C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213332, RefRangeEnd = 213334, XrefRangeStart = 213262, XrefRangeEnd = 213332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x001DAA88 File Offset: 0x001D8C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213391, RefRangeEnd = 213393, XrefRangeStart = 213334, XrefRangeEnd = 213391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x001DAAC4 File Offset: 0x001D8CC4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x001DAB00 File Offset: 0x001D8D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213393, RefRangeEnd = 213394, XrefRangeStart = 213393, XrefRangeEnd = 213393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x001DAB3C File Offset: 0x001D8D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213394, RefRangeEnd = 213395, XrefRangeStart = 213394, XrefRangeEnd = 213394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x001DAB78 File Offset: 0x001D8D78
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x001DABB4 File Offset: 0x001D8DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213395, XrefRangeEnd = 213417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x000316AF File Offset: 0x0002F8AF
		public CasinoGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x001DABF0 File Offset: 0x001D8DF0
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x000316B8 File Offset: 0x0002F8B8
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x001DAC0C File Offset: 0x001D8E0C
		// (set) Token: 0x0600692F RID: 26927 RVA: 0x000316C6 File Offset: 0x0002F8C6
		public unsafe static float CAMERA_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x001DAC28 File Offset: 0x001D8E28
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x000316D4 File Offset: 0x0002F8D4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x001DAC50 File Offset: 0x001D8E50
		// (set) Token: 0x06006933 RID: 26931 RVA: 0x000316EF File Offset: 0x0002F8EF
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x001DAC80 File Offset: 0x001D8E80
		// (set) Token: 0x06006935 RID: 26933 RVA: 0x0003170E File Offset: 0x0002F90E
		public unsafe CasinoGameInteraction Interaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x001DACB0 File Offset: 0x001D8EB0
		// (set) Token: 0x06006937 RID: 26935 RVA: 0x0003172D File Offset: 0x0002F92D
		public unsafe Il2CppReferenceArray<Transform> DefaultCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x001DACE0 File Offset: 0x001D8EE0
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x0003174C File Offset: 0x0002F94C
		public unsafe Transform localDefaultCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x001DAD10 File Offset: 0x001D8F10
		// (set) Token: 0x0600693B RID: 26939 RVA: 0x0003176B File Offset: 0x0002F96B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x001DAD38 File Offset: 0x001D8F38
		// (set) Token: 0x0600693D RID: 26941 RVA: 0x00031786 File Offset: 0x0002F986
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040047F5 RID: 18421
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x040047F6 RID: 18422
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_LERP_TIME;

		// Token: 0x040047F7 RID: 18423
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040047F8 RID: 18424
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040047F9 RID: 18425
		private static readonly IntPtr NativeFieldInfoPtr_Interaction;

		// Token: 0x040047FA RID: 18426
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCameraTransforms;

		// Token: 0x040047FB RID: 18427
		private static readonly IntPtr NativeFieldInfoPtr_localDefaultCameraTransform;

		// Token: 0x040047FC RID: 18428
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040047FD RID: 18429
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040047FE RID: 18430
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040047FF RID: 18431
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04004800 RID: 18432
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0;

		// Token: 0x04004801 RID: 18433
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004802 RID: 18434
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0;

		// Token: 0x04004803 RID: 18435
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04004804 RID: 18436
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004805 RID: 18437
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004806 RID: 18438
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1;

		// Token: 0x04004807 RID: 18439
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_1;

		// Token: 0x04004808 RID: 18440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004809 RID: 18441
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400480A RID: 18442
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400480B RID: 18443
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400480C RID: 18444
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
