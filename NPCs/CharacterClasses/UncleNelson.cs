using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000359 RID: 857
	public class UncleNelson : NPC
	{
		// Token: 0x06003E45 RID: 15941 RVA: 0x0013E888 File Offset: 0x0013CA88
		// Note: this type is marked as 'beforefieldinit'.
		static UncleNelson()
		{
			Il2CppClassPointerStore<UncleNelson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "UncleNelson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr);
			UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage_Demo");
			UncleNelson.NativeFieldInfoPtr_InitialMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "InitialMessage");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted");
			UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670645);
			UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670646);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670647);
			UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670648);
			UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670649);
			UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr, 100670650);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x0013E980 File Offset: 0x0013CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148622, XrefRangeEnd = 148643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendInitialMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr_SendInitialMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x0013E9B4 File Offset: 0x0013CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148643, XrefRangeEnd = 148652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UncleNelson() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UncleNelson>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UncleNelson.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x0013E9F0 File Offset: 0x0013CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0013EA2C File Offset: 0x0013CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0013EA68 File Offset: 0x0013CC68
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0013EAA4 File Offset: 0x0013CCA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UncleNelson.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x0001F527 File Offset: 0x0001D727
		public UncleNelson(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x0013EAE0 File Offset: 0x0013CCE0
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x0001F530 File Offset: 0x0001D730
		public unsafe string InitialMessage_Demo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage_Demo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x0013EB08 File Offset: 0x0013CD08
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x0001F54F File Offset: 0x0001D74F
		public unsafe string InitialMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_InitialMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x0013EB30 File Offset: 0x0013CD30
		// (set) Token: 0x06003E52 RID: 15954 RVA: 0x0001F56E File Offset: 0x0001D76E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x0013EB58 File Offset: 0x0013CD58
		// (set) Token: 0x06003E54 RID: 15956 RVA: 0x0001F589 File Offset: 0x0001D789
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UncleNelson.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage_Demo;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeFieldInfoPtr_InitialMessage;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeMethodInfoPtr_SendInitialMessage_Public_Void_0;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
