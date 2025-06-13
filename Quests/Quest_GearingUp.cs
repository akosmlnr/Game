using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C6 RID: 454
	public class Quest_GearingUp : Quest
	{
		// Token: 0x060026B1 RID: 9905 RVA: 0x000ED004 File Offset: 0x000EB204
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GearingUp()
		{
			Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GearingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr);
			Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "WaitForDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "CollectDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "Supplier");
			Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "setCollectionPosition");
			Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667665);
			Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667666);
			Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667667);
			Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667668);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000ED0D4 File Offset: 0x000EB2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120185, XrefRangeEnd = 120194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000ED110 File Offset: 0x000EB310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120194, XrefRangeEnd = 120229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000ED14C File Offset: 0x000EB34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120229, XrefRangeEnd = 120230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000ED180 File Offset: 0x000EB380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120230, XrefRangeEnd = 120234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GearingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00015585 File Offset: 0x00013785
		public Quest_GearingUp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000ED1BC File Offset: 0x000EB3BC
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x0001558E File Offset: 0x0001378E
		public unsafe QuestEntry WaitForDropEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000ED1EC File Offset: 0x000EB3EC
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x000155AD File Offset: 0x000137AD
		public unsafe QuestEntry CollectDropEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000ED21C File Offset: 0x000EB41C
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x000155CC File Offset: 0x000137CC
		public unsafe Supplier Supplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000ED24C File Offset: 0x000EB44C
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x000155EB File Offset: 0x000137EB
		public unsafe bool setCollectionPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition)) = value;
			}
		}

		// Token: 0x040019C7 RID: 6599
		private static readonly System.IntPtr NativeFieldInfoPtr_WaitForDropEntry;

		// Token: 0x040019C8 RID: 6600
		private static readonly System.IntPtr NativeFieldInfoPtr_CollectDropEntry;

		// Token: 0x040019C9 RID: 6601
		private static readonly System.IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x040019CA RID: 6602
		private static readonly System.IntPtr NativeFieldInfoPtr_setCollectionPosition;

		// Token: 0x040019CB RID: 6603
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019CC RID: 6604
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019CD RID: 6605
		private static readonly System.IntPtr NativeMethodInfoPtr_DropReady_Private_Void_0;

		// Token: 0x040019CE RID: 6606
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000902 RID: 2306
		[ObfuscatedName("ScheduleOne.Quests.Quest_GearingUp+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C86C RID: 51308 RVA: 0x0031005C File Offset: 0x0030E25C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr);
				Quest_GearingUp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9");
				Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9__5_0");
				Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667670);
				Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667671);
			}

			// Token: 0x0600C86D RID: 51309 RVA: 0x003100D8 File Offset: 0x0030E2D8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C86E RID: 51310 RVA: 0x00310114 File Offset: 0x0030E314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120184, XrefRangeEnd = 120185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MinPass_b__5_0(DeadDrop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C86F RID: 51311 RVA: 0x00061319 File Offset: 0x0005F519
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E45 RID: 15941
			// (get) Token: 0x0600C870 RID: 51312 RVA: 0x00310164 File Offset: 0x0030E364
			// (set) Token: 0x0600C871 RID: 51313 RVA: 0x00061322 File Offset: 0x0005F522
			public unsafe static Quest_GearingUp.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_GearingUp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E46 RID: 15942
			// (get) Token: 0x0600C872 RID: 51314 RVA: 0x0031018C File Offset: 0x0030E38C
			// (set) Token: 0x0600C873 RID: 51315 RVA: 0x00061334 File Offset: 0x0005F534
			public unsafe static Il2CppSystem.Predicate<DeadDrop> __9__5_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DeadDrop>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087F5 RID: 34805
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087F6 RID: 34806
			private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040087F7 RID: 34807
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087F8 RID: 34808
			private static readonly System.IntPtr NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0;
		}
	}
}
