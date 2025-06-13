using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004E8 RID: 1256
	public class PropertyDoorController : DoorController
	{
		// Token: 0x06006CE2 RID: 27874 RVA: 0x001E796C File Offset: 0x001E5B6C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDoorController()
		{
			Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "PropertyDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr);
			PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "WANTED_PLAYER_CLOSE_DISTANCE");
			PropertyDoorController.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "Property");
			PropertyDoorController.NativeFieldInfoPtr_IsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "IsUnlocked");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted");
			PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677189);
			PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677190);
			PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677191);
			PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677192);
			PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677193);
			PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677194);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677195);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677196);
			PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677197);
			PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr, 100677198);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x001E7AC8 File Offset: 0x001E5CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219643, XrefRangeEnd = 219659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x001E7B04 File Offset: 0x001E5D04
		[CallerCount(0)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x001E7B38 File Offset: 0x001E5D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219659, XrefRangeEnd = 219669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_CheckClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x001E7B6C File Offset: 0x001E5D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219669, XrefRangeEnd = 219695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x001E7BDC File Offset: 0x001E5DDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219729, RefRangeEnd = 219731, XrefRangeStart = 219695, XrefRangeEnd = 219729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestWantedPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x001E7C1C File Offset: 0x001E5E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219731, XrefRangeEnd = 219732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDoorController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x001E7C58 File Offset: 0x001E5E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219732, XrefRangeEnd = 219733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x001E7C94 File Offset: 0x001E5E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219733, XrefRangeEnd = 219734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x001E7CD0 File Offset: 0x001E5ED0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x001E7D0C File Offset: 0x001E5F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219734, XrefRangeEnd = 219749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDoorController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00033408 File Offset: 0x00031608
		public PropertyDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x001E7D48 File Offset: 0x001E5F48
		// (set) Token: 0x06006CEF RID: 27887 RVA: 0x00033411 File Offset: 0x00031611
		public unsafe static float WANTED_PLAYER_CLOSE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyDoorController.NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x001E7D64 File Offset: 0x001E5F64
		// (set) Token: 0x06006CF1 RID: 27889 RVA: 0x0003341F File Offset: 0x0003161F
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x001E7D94 File Offset: 0x001E5F94
		// (set) Token: 0x06006CF3 RID: 27891 RVA: 0x0003343E File Offset: 0x0003163E
		public unsafe bool IsUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_IsUnlocked)) = value;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x001E7DBC File Offset: 0x001E5FBC
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x00033459 File Offset: 0x00031659
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x001E7DE4 File Offset: 0x001E5FE4
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x00033474 File Offset: 0x00031674
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004A84 RID: 19076
		private static readonly IntPtr NativeFieldInfoPtr_WANTED_PLAYER_CLOSE_DISTANCE;

		// Token: 0x04004A85 RID: 19077
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004A86 RID: 19078
		private static readonly IntPtr NativeFieldInfoPtr_IsUnlocked;

		// Token: 0x04004A87 RID: 19079
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004A88 RID: 19080
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004A89 RID: 19081
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004A8A RID: 19082
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

		// Token: 0x04004A8B RID: 19083
		private static readonly IntPtr NativeMethodInfoPtr_CheckClose_Private_Void_0;

		// Token: 0x04004A8C RID: 19084
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04004A8D RID: 19085
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestWantedPlayer_Private_Player_0;

		// Token: 0x04004A8E RID: 19086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A8F RID: 19087
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004A90 RID: 19088
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004A91 RID: 19089
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004A92 RID: 19090
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
