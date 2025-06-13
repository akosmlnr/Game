using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005CE RID: 1486
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060081C0 RID: 33216 RVA: 0x0022E198 File Offset: 0x0022C398
		// Note: this type is marked as 'beforefieldinit'.
		static Product_Equippable()
		{
			Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "Product_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr);
			Product_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Visuals");
			Product_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ModelContainer");
			Product_Equippable.NativeFieldInfoPtr_Consumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Consumable");
			Product_Equippable.NativeFieldInfoPtr_ConsumeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeDescription");
			Product_Equippable.NativeFieldInfoPtr_ConsumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeTime");
			Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "EffectsApplyDelay");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationBool");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationTrigger");
			Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeEquippableAssetPath");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputStart");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputComplete");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputCancel");
			Product_Equippable.NativeFieldInfoPtr_consumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeTime");
			Product_Equippable.NativeFieldInfoPtr_consumingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumingInProgress");
			Product_Equippable.NativeFieldInfoPtr_defaultModelPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "defaultModelPosition");
			Product_Equippable.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "productAmount");
			Product_Equippable.NativeFieldInfoPtr_consumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeRoutine");
			Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679691);
			Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679692);
			Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679693);
			Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679694);
			Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679695);
			Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679696);
			Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679697);
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x0022E3A8 File Offset: 0x0022C5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246910, XrefRangeEnd = 246965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x0022E3F8 File Offset: 0x0022C5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246965, XrefRangeEnd = 246991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x0022E434 File Offset: 0x0022C634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246991, XrefRangeEnd = 247034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x0022E470 File Offset: 0x0022C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247034, XrefRangeEnd = 247067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Consume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x0022E4AC File Offset: 0x0022C6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247067, XrefRangeEnd = 247075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x0022E4E8 File Offset: 0x0022C6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247075, XrefRangeEnd = 247091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x0022E524 File Offset: 0x0022C724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247091, XrefRangeEnd = 247096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x0003D330 File Offset: 0x0003B530
		public Product_Equippable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x0022E564 File Offset: 0x0022C764
		// (set) Token: 0x060081CA RID: 33226 RVA: 0x0003D339 File Offset: 0x0003B539
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x060081CB RID: 33227 RVA: 0x0022E594 File Offset: 0x0022C794
		// (set) Token: 0x060081CC RID: 33228 RVA: 0x0003D358 File Offset: 0x0003B558
		public unsafe Transform ModelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x0022E5C4 File Offset: 0x0022C7C4
		// (set) Token: 0x060081CE RID: 33230 RVA: 0x0003D377 File Offset: 0x0003B577
		public unsafe bool Consumable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable)) = value;
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x060081CF RID: 33231 RVA: 0x0022E5EC File Offset: 0x0022C7EC
		// (set) Token: 0x060081D0 RID: 33232 RVA: 0x0003D392 File Offset: 0x0003B592
		public unsafe string ConsumeDescription
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x060081D1 RID: 33233 RVA: 0x0022E614 File Offset: 0x0022C814
		// (set) Token: 0x060081D2 RID: 33234 RVA: 0x0003D3B1 File Offset: 0x0003B5B1
		public unsafe float ConsumeTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime)) = value;
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x0022E63C File Offset: 0x0022C83C
		// (set) Token: 0x060081D4 RID: 33236 RVA: 0x0003D3CC File Offset: 0x0003B5CC
		public unsafe float EffectsApplyDelay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay)) = value;
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x0022E664 File Offset: 0x0022C864
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x0003D3E7 File Offset: 0x0003B5E7
		public unsafe string ConsumeAnimationBool
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x0022E68C File Offset: 0x0022C88C
		// (set) Token: 0x060081D8 RID: 33240 RVA: 0x0003D406 File Offset: 0x0003B606
		public unsafe string ConsumeAnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x0022E6B4 File Offset: 0x0022C8B4
		// (set) Token: 0x060081DA RID: 33242 RVA: 0x0003D425 File Offset: 0x0003B625
		public unsafe string ConsumeEquippableAssetPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x060081DB RID: 33243 RVA: 0x0022E6DC File Offset: 0x0022C8DC
		// (set) Token: 0x060081DC RID: 33244 RVA: 0x0003D444 File Offset: 0x0003B644
		public unsafe UnityEvent onConsumeInputStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x060081DD RID: 33245 RVA: 0x0022E70C File Offset: 0x0022C90C
		// (set) Token: 0x060081DE RID: 33246 RVA: 0x0003D463 File Offset: 0x0003B663
		public unsafe UnityEvent onConsumeInputComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x060081DF RID: 33247 RVA: 0x0022E73C File Offset: 0x0022C93C
		// (set) Token: 0x060081E0 RID: 33248 RVA: 0x0003D482 File Offset: 0x0003B682
		public unsafe UnityEvent onConsumeInputCancel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x060081E1 RID: 33249 RVA: 0x0022E76C File Offset: 0x0022C96C
		// (set) Token: 0x060081E2 RID: 33250 RVA: 0x0003D4A1 File Offset: 0x0003B6A1
		public unsafe float consumeTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime)) = value;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x0022E794 File Offset: 0x0022C994
		// (set) Token: 0x060081E4 RID: 33252 RVA: 0x0003D4BC File Offset: 0x0003B6BC
		public unsafe bool consumingInProgress
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress)) = value;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x060081E5 RID: 33253 RVA: 0x0022E7BC File Offset: 0x0022C9BC
		// (set) Token: 0x060081E6 RID: 33254 RVA: 0x0003D4D7 File Offset: 0x0003B6D7
		public unsafe Vector3 defaultModelPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition)) = value;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x060081E7 RID: 33255 RVA: 0x0022E7E4 File Offset: 0x0022C9E4
		// (set) Token: 0x060081E8 RID: 33256 RVA: 0x0003D4F2 File Offset: 0x0003B6F2
		public unsafe int productAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount)) = value;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x0022E80C File Offset: 0x0022CA0C
		// (set) Token: 0x060081EA RID: 33258 RVA: 0x0003D50D File Offset: 0x0003B70D
		public unsafe Coroutine consumeRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005877 RID: 22647
		private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005878 RID: 22648
		private static readonly System.IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04005879 RID: 22649
		private static readonly System.IntPtr NativeFieldInfoPtr_Consumable;

		// Token: 0x0400587A RID: 22650
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeDescription;

		// Token: 0x0400587B RID: 22651
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeTime;

		// Token: 0x0400587C RID: 22652
		private static readonly System.IntPtr NativeFieldInfoPtr_EffectsApplyDelay;

		// Token: 0x0400587D RID: 22653
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeAnimationBool;

		// Token: 0x0400587E RID: 22654
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeAnimationTrigger;

		// Token: 0x0400587F RID: 22655
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeEquippableAssetPath;

		// Token: 0x04005880 RID: 22656
		private static readonly System.IntPtr NativeFieldInfoPtr_onConsumeInputStart;

		// Token: 0x04005881 RID: 22657
		private static readonly System.IntPtr NativeFieldInfoPtr_onConsumeInputComplete;

		// Token: 0x04005882 RID: 22658
		private static readonly System.IntPtr NativeFieldInfoPtr_onConsumeInputCancel;

		// Token: 0x04005883 RID: 22659
		private static readonly System.IntPtr NativeFieldInfoPtr_consumeTime;

		// Token: 0x04005884 RID: 22660
		private static readonly System.IntPtr NativeFieldInfoPtr_consumingInProgress;

		// Token: 0x04005885 RID: 22661
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultModelPosition;

		// Token: 0x04005886 RID: 22662
		private static readonly System.IntPtr NativeFieldInfoPtr_productAmount;

		// Token: 0x04005887 RID: 22663
		private static readonly System.IntPtr NativeFieldInfoPtr_consumeRoutine;

		// Token: 0x04005888 RID: 22664
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005889 RID: 22665
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400588A RID: 22666
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400588B RID: 22667
		private static readonly System.IntPtr NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0;

		// Token: 0x0400588C RID: 22668
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0;

		// Token: 0x0400588D RID: 22669
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400588E RID: 22670
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B21 RID: 2849
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<<Consume>g__ConsumeRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D9C5 RID: 55749 RVA: 0x00341634 File Offset: 0x0033F834
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<<Consume>g__ConsumeRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679698);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679699);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679700);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679701);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679702);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679703);
			}

			// Token: 0x0600D9C6 RID: 55750 RVA: 0x00341714 File Offset: 0x0033F914
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x0034175C File Offset: 0x0033F95C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9C8 RID: 55752 RVA: 0x00341790 File Offset: 0x0033F990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246894, XrefRangeEnd = 246899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004331 RID: 17201
			// (get) Token: 0x0600D9C9 RID: 55753 RVA: 0x003417CC File Offset: 0x0033F9CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D9CA RID: 55754 RVA: 0x0034180C File Offset: 0x0033FA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246899, XrefRangeEnd = 246904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004332 RID: 17202
			// (get) Token: 0x0600D9CB RID: 55755 RVA: 0x00341840 File Offset: 0x0033FA40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D9CC RID: 55756 RVA: 0x00069A76 File Offset: 0x00067C76
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700432E RID: 17198
			// (get) Token: 0x0600D9CD RID: 55757 RVA: 0x00341880 File Offset: 0x0033FA80
			// (set) Token: 0x0600D9CE RID: 55758 RVA: 0x00069A7F File Offset: 0x00067C7F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700432F RID: 17199
			// (get) Token: 0x0600D9CF RID: 55759 RVA: 0x003418A8 File Offset: 0x0033FAA8
			// (set) Token: 0x0600D9D0 RID: 55760 RVA: 0x00069A9A File Offset: 0x00067C9A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004330 RID: 17200
			// (get) Token: 0x0600D9D1 RID: 55761 RVA: 0x003418D8 File Offset: 0x0033FAD8
			// (set) Token: 0x0600D9D2 RID: 55762 RVA: 0x00069AB9 File Offset: 0x00067CB9
			public unsafe Product_Equippable __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400929F RID: 37535
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092A0 RID: 37536
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092A1 RID: 37537
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092A2 RID: 37538
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092A3 RID: 37539
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092A4 RID: 37540
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092A5 RID: 37541
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092A6 RID: 37542
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092A7 RID: 37543
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B22 RID: 2850
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D9D3 RID: 55763 RVA: 0x00341908 File Offset: 0x0033FB08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr);
				Product_Equippable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9");
				Product_Equippable.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9__17_0");
				Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679705);
				Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679706);
			}

			// Token: 0x0600D9D4 RID: 55764 RVA: 0x00341984 File Offset: 0x0033FB84
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D9D5 RID: 55765 RVA: 0x003419C0 File Offset: 0x0033FBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246904, XrefRangeEnd = 246910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Equip_b__17_0(Transform c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D9D6 RID: 55766 RVA: 0x00069AD8 File Offset: 0x00067CD8
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004333 RID: 17203
			// (get) Token: 0x0600D9D7 RID: 55767 RVA: 0x00341A10 File Offset: 0x0033FC10
			// (set) Token: 0x0600D9D8 RID: 55768 RVA: 0x00069AE1 File Offset: 0x00067CE1
			public unsafe static Product_Equippable.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004334 RID: 17204
			// (get) Token: 0x0600D9D9 RID: 55769 RVA: 0x00341A38 File Offset: 0x0033FC38
			// (set) Token: 0x0600D9DA RID: 55770 RVA: 0x00069AF3 File Offset: 0x00067CF3
			public unsafe static Il2CppSystem.Func<Transform, bool> __9__17_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092A8 RID: 37544
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092A9 RID: 37545
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040092AA RID: 37546
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092AB RID: 37547
			private static readonly System.IntPtr NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0;
		}
	}
}
