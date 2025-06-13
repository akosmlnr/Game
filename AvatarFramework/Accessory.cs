using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000614 RID: 1556
	public class Accessory : MonoBehaviour
	{
		// Token: 0x060086EB RID: 34539 RVA: 0x0023F1A0 File Offset: 0x0023D3A0
		// Note: this type is marked as 'beforefieldinit'.
		static Accessory()
		{
			Il2CppClassPointerStore<Accessory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Accessory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Accessory>.NativeClassPtr);
			Accessory.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "Name");
			Accessory.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "AssetPath");
			Accessory.NativeFieldInfoPtr_ReduceFootSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ReduceFootSize");
			Accessory.NativeFieldInfoPtr_FootSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "FootSizeReduction");
			Accessory.NativeFieldInfoPtr_ShouldBlockHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ShouldBlockHair");
			Accessory.NativeFieldInfoPtr_ColorAllMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ColorAllMeshes");
			Accessory.NativeFieldInfoPtr_meshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "meshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToBind");
			Accessory.NativeFieldInfoPtr_shapeKeyMeshRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "shapeKeyMeshRends");
			Accessory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100680278);
			Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100680279);
			Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100680280);
			Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100680281);
			Accessory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100680282);
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x0023F2FC File Offset: 0x0023D4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253013, XrefRangeEnd = 253015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x0023F330 File Offset: 0x0023D530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253025, RefRangeEnd = 253029, XrefRangeStart = 253015, XrefRangeEnd = 253025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x0023F370 File Offset: 0x0023D570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253034, RefRangeEnd = 253036, XrefRangeStart = 253029, XrefRangeEnd = 253034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x0023F3BC File Offset: 0x0023D5BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253038, RefRangeEnd = 253039, XrefRangeStart = 253036, XrefRangeEnd = 253038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindBones(Il2CppReferenceArray<Transform> bones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bones);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x0023F400 File Offset: 0x0023D600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253040, RefRangeEnd = 253041, XrefRangeStart = 253039, XrefRangeEnd = 253040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Accessory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Accessory>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x0003FB36 File Offset: 0x0003DD36
		public Accessory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x060086F2 RID: 34546 RVA: 0x0023F43C File Offset: 0x0023D63C
		// (set) Token: 0x060086F3 RID: 34547 RVA: 0x0003FB3F File Offset: 0x0003DD3F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x0023F464 File Offset: 0x0023D664
		// (set) Token: 0x060086F5 RID: 34549 RVA: 0x0003FB5E File Offset: 0x0003DD5E
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x0023F48C File Offset: 0x0023D68C
		// (set) Token: 0x060086F7 RID: 34551 RVA: 0x0003FB7D File Offset: 0x0003DD7D
		public unsafe bool ReduceFootSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize)) = value;
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x060086F8 RID: 34552 RVA: 0x0023F4B4 File Offset: 0x0023D6B4
		// (set) Token: 0x060086F9 RID: 34553 RVA: 0x0003FB98 File Offset: 0x0003DD98
		public unsafe float FootSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction)) = value;
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x060086FA RID: 34554 RVA: 0x0023F4DC File Offset: 0x0023D6DC
		// (set) Token: 0x060086FB RID: 34555 RVA: 0x0003FBB3 File Offset: 0x0003DDB3
		public unsafe bool ShouldBlockHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair)) = value;
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x060086FC RID: 34556 RVA: 0x0023F504 File Offset: 0x0023D704
		// (set) Token: 0x060086FD RID: 34557 RVA: 0x0003FBCE File Offset: 0x0003DDCE
		public unsafe bool ColorAllMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes)) = value;
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x060086FE RID: 34558 RVA: 0x0023F52C File Offset: 0x0023D72C
		// (set) Token: 0x060086FF RID: 34559 RVA: 0x0003FBE9 File Offset: 0x0003DDE9
		public unsafe Il2CppReferenceArray<MeshRenderer> meshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x06008700 RID: 34560 RVA: 0x0023F55C File Offset: 0x0023D75C
		// (set) Token: 0x06008701 RID: 34561 RVA: 0x0003FC08 File Offset: 0x0003DE08
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x06008702 RID: 34562 RVA: 0x0023F58C File Offset: 0x0023D78C
		// (set) Token: 0x06008703 RID: 34563 RVA: 0x0003FC27 File Offset: 0x0003DE27
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToBind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x0023F5BC File Offset: 0x0023D7BC
		// (set) Token: 0x06008705 RID: 34565 RVA: 0x0003FC46 File Offset: 0x0003DE46
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> shapeKeyMeshRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BE8 RID: 23528
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005BE9 RID: 23529
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005BEA RID: 23530
		private static readonly IntPtr NativeFieldInfoPtr_ReduceFootSize;

		// Token: 0x04005BEB RID: 23531
		private static readonly IntPtr NativeFieldInfoPtr_FootSizeReduction;

		// Token: 0x04005BEC RID: 23532
		private static readonly IntPtr NativeFieldInfoPtr_ShouldBlockHair;

		// Token: 0x04005BED RID: 23533
		private static readonly IntPtr NativeFieldInfoPtr_ColorAllMeshes;

		// Token: 0x04005BEE RID: 23534
		private static readonly IntPtr NativeFieldInfoPtr_meshesToColor;

		// Token: 0x04005BEF RID: 23535
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToColor;

		// Token: 0x04005BF0 RID: 23536
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToBind;

		// Token: 0x04005BF1 RID: 23537
		private static readonly IntPtr NativeFieldInfoPtr_shapeKeyMeshRends;

		// Token: 0x04005BF2 RID: 23538
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005BF3 RID: 23539
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0;

		// Token: 0x04005BF4 RID: 23540
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0;

		// Token: 0x04005BF5 RID: 23541
		private static readonly IntPtr NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04005BF6 RID: 23542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
