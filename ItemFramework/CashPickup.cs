using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F4 RID: 1524
	public class CashPickup : ItemPickup
	{
		// Token: 0x0600853D RID: 34109 RVA: 0x00238FD8 File Offset: 0x002371D8
		// Note: this type is marked as 'beforefieldinit'.
		static CashPickup()
		{
			Il2CppClassPointerStore<CashPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashPickup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPickup>.NativeClassPtr);
			CashPickup.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "Value");
			CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted");
			CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted");
			CashPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680062);
			CashPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680063);
			CashPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680064);
			CashPickup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680065);
			CashPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680066);
			CashPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680067);
			CashPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680068);
			CashPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPickup>.NativeClassPtr, 100680069);
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x002390E4 File Offset: 0x002372E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250771, XrefRangeEnd = 250776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x00239120 File Offset: 0x00237320
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x00239168 File Offset: 0x00237368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250776, XrefRangeEnd = 250783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x002391A4 File Offset: 0x002373A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250783, XrefRangeEnd = 250784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPickup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPickup>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPickup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x002391E0 File Offset: 0x002373E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250784, XrefRangeEnd = 250791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x0023921C File Offset: 0x0023741C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x00239258 File Offset: 0x00237458
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x00239294 File Offset: 0x00237494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250791, XrefRangeEnd = 250811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x0003F132 File Offset: 0x0003D332
		public CashPickup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x06008547 RID: 34119 RVA: 0x002392D0 File Offset: 0x002374D0
		// (set) Token: 0x06008548 RID: 34120 RVA: 0x0003F13B File Offset: 0x0003D33B
		public unsafe float Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x06008549 RID: 34121 RVA: 0x002392F8 File Offset: 0x002374F8
		// (set) Token: 0x0600854A RID: 34122 RVA: 0x0003F156 File Offset: 0x0003D356
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x00239320 File Offset: 0x00237520
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x0003F171 File Offset: 0x0003D371
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPickup.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005AAF RID: 23215
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04005AB0 RID: 23216
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005AB1 RID: 23217
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005AB2 RID: 23218
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_Void_0;

		// Token: 0x04005AB3 RID: 23219
		private static readonly IntPtr NativeMethodInfoPtr_CanPickup_Protected_Virtual_Boolean_0;

		// Token: 0x04005AB4 RID: 23220
		private static readonly IntPtr NativeMethodInfoPtr_Pickup_Protected_Virtual_Void_0;

		// Token: 0x04005AB5 RID: 23221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AB6 RID: 23222
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005AB7 RID: 23223
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005AB8 RID: 23224
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005AB9 RID: 23225
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
