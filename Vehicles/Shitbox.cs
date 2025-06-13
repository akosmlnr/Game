using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000509 RID: 1289
	public class Shitbox : LandVehicle
	{
		// Token: 0x060070D2 RID: 28882 RVA: 0x001F4770 File Offset: 0x001F2970
		// Note: this type is marked as 'beforefieldinit'.
		static Shitbox()
		{
			Il2CppClassPointerStore<Shitbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Shitbox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox>.NativeClassPtr);
			Shitbox.NativeFieldInfoPtr_LoanSharkVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisuals");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677652);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677653);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677654);
			Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677655);
			Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677656);
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x001F4840 File Offset: 0x001F2A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224462, XrefRangeEnd = 224463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shitbox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x001F487C File Offset: 0x001F2A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224463, XrefRangeEnd = 224464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x001F48B8 File Offset: 0x001F2AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224464, XrefRangeEnd = 224465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x001F48F4 File Offset: 0x001F2AF4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x001F4930 File Offset: 0x001F2B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224465, XrefRangeEnd = 224466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x0003526B File Offset: 0x0003346B
		public Shitbox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x001F496C File Offset: 0x001F2B6C
		// (set) Token: 0x060070DA RID: 28890 RVA: 0x00035274 File Offset: 0x00033474
		public unsafe LoanSharkCarVisuals LoanSharkVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoanSharkCarVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x060070DB RID: 28891 RVA: 0x001F499C File Offset: 0x001F2B9C
		// (set) Token: 0x060070DC RID: 28892 RVA: 0x00035293 File Offset: 0x00033493
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x001F49C4 File Offset: 0x001F2BC4
		// (set) Token: 0x060070DE RID: 28894 RVA: 0x000352AE File Offset: 0x000334AE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVisuals;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000AB6 RID: 2742
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			// Token: 0x0600D645 RID: 54853 RVA: 0x00337814 File Offset: 0x00335A14
			// Note: this type is marked as 'beforefieldinit'.
			static LoanSharkVisualsData()
			{
				Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisualsData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr);
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "Enabled");
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "NoteVisible");
				Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, 100677657);
			}

			// Token: 0x0600D646 RID: 54854 RVA: 0x0033787C File Offset: 0x00335A7C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 136226, RefRangeEnd = 136227, XrefRangeStart = 136226, XrefRangeEnd = 136227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoanSharkVisualsData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D647 RID: 54855 RVA: 0x00067FD0 File Offset: 0x000661D0
			public LoanSharkVisualsData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0600D648 RID: 54856 RVA: 0x003378B8 File Offset: 0x00335AB8
			// (set) Token: 0x0600D649 RID: 54857 RVA: 0x00067FD9 File Offset: 0x000661D9
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x1700423B RID: 16955
			// (get) Token: 0x0600D64A RID: 54858 RVA: 0x003378E0 File Offset: 0x00335AE0
			// (set) Token: 0x0600D64B RID: 54859 RVA: 0x00067FF4 File Offset: 0x000661F4
			public unsafe bool NoteVisible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible)) = value;
				}
			}

			// Token: 0x0400909E RID: 37022
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x0400909F RID: 37023
			private static readonly IntPtr NativeFieldInfoPtr_NoteVisible;

			// Token: 0x040090A0 RID: 37024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
