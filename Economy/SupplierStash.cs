using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200043E RID: 1086
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x06005E45 RID: 24133 RVA: 0x001B5E30 File Offset: 0x001B4030
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierStash()
		{
			Il2CppClassPointerStore<SupplierStash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierStash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr);
			SupplierStash.NativeFieldInfoPtr_locationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "locationDescription");
			SupplierStash.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Supplier");
			SupplierStash.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Storage");
			SupplierStash.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "IntObj");
			SupplierStash.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Light");
			SupplierStash.NativeFieldInfoPtr_StashPoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "StashPoI");
			SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "<CashAmount>k__BackingField");
			SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675414);
			SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675415);
			SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675416);
			SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675417);
			SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675418);
			SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675419);
			SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675420);
			SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675421);
			SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675422);
			SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675423);
			SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675424);
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x001B5FC8 File Offset: 0x001B41C8
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x001B6004 File Offset: 0x001B4204
		public unsafe float CashAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x001B6044 File Offset: 0x001B4244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199164, XrefRangeEnd = 199226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x001B6080 File Offset: 0x001B4280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199226, XrefRangeEnd = 199241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x001B60BC File Offset: 0x001B42BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199241, XrefRangeEnd = 199252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SupplierUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x001B60F0 File Offset: 0x001B42F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199266, RefRangeEnd = 199267, XrefRangeStart = 199252, XrefRangeEnd = 199266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x001B6124 File Offset: 0x001B4324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199267, XrefRangeEnd = 199288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x001B6158 File Offset: 0x001B4358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199302, RefRangeEnd = 199303, XrefRangeStart = 199288, XrefRangeEnd = 199302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x001B6198 File Offset: 0x001B4398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199303, XrefRangeEnd = 199304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x001B61CC File Offset: 0x001B43CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199304, XrefRangeEnd = 199309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierStash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x001B6208 File Offset: 0x001B4408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_0(NPCRelationData.EUnlockType type, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0002C373 File Offset: 0x0002A573
		public SupplierStash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x001B6254 File Offset: 0x001B4454
		// (set) Token: 0x06005E53 RID: 24147 RVA: 0x0002C37C File Offset: 0x0002A57C
		public unsafe string locationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06005E54 RID: 24148 RVA: 0x001B627C File Offset: 0x001B447C
		// (set) Token: 0x06005E55 RID: 24149 RVA: 0x0002C39B File Offset: 0x0002A59B
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06005E56 RID: 24150 RVA: 0x001B62AC File Offset: 0x001B44AC
		// (set) Token: 0x06005E57 RID: 24151 RVA: 0x0002C3BA File Offset: 0x0002A5BA
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06005E58 RID: 24152 RVA: 0x001B62DC File Offset: 0x001B44DC
		// (set) Token: 0x06005E59 RID: 24153 RVA: 0x0002C3D9 File Offset: 0x0002A5D9
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005E5A RID: 24154 RVA: 0x001B630C File Offset: 0x001B450C
		// (set) Token: 0x06005E5B RID: 24155 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06005E5C RID: 24156 RVA: 0x001B633C File Offset: 0x001B453C
		// (set) Token: 0x06005E5D RID: 24157 RVA: 0x0002C417 File Offset: 0x0002A617
		public unsafe POI StashPoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x001B636C File Offset: 0x001B456C
		// (set) Token: 0x06005E5F RID: 24159 RVA: 0x0002C436 File Offset: 0x0002A636
		public unsafe float _CashAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x0400407E RID: 16510
		private static readonly IntPtr NativeFieldInfoPtr_locationDescription;

		// Token: 0x0400407F RID: 16511
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04004080 RID: 16512
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04004081 RID: 16513
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004082 RID: 16514
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04004083 RID: 16515
		private static readonly IntPtr NativeFieldInfoPtr_StashPoI;

		// Token: 0x04004084 RID: 16516
		private static readonly IntPtr NativeFieldInfoPtr__CashAmount_k__BackingField;

		// Token: 0x04004085 RID: 16517
		private static readonly IntPtr NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0;

		// Token: 0x04004086 RID: 16518
		private static readonly IntPtr NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0;

		// Token: 0x04004087 RID: 16519
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004088 RID: 16520
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004089 RID: 16521
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0;

		// Token: 0x0400408A RID: 16522
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCash_Private_Void_0;

		// Token: 0x0400408B RID: 16523
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x0400408C RID: 16524
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x0400408D RID: 16525
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x0400408E RID: 16526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400408F RID: 16527
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0;
	}
}
