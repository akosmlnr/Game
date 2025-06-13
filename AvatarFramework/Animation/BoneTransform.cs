using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200062D RID: 1581
	public class BoneTransform : Il2CppSystem.Object
	{
		// Token: 0x06008A75 RID: 35445 RVA: 0x00249A1C File Offset: 0x00247C1C
		// Note: this type is marked as 'beforefieldinit'.
		static BoneTransform()
		{
			Il2CppClassPointerStore<BoneTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "BoneTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr);
			BoneTransform.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Position>k__BackingField");
			BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, "<Rotation>k__BackingField");
			BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680663);
			BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680664);
			BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680665);
			BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680666);
			BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr, 100680667);
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x06008A76 RID: 35446 RVA: 0x00249AD8 File Offset: 0x00247CD8
		// (set) Token: 0x06008A77 RID: 35447 RVA: 0x00249B14 File Offset: 0x00247D14
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x06008A78 RID: 35448 RVA: 0x00249B54 File Offset: 0x00247D54
		// (set) Token: 0x06008A79 RID: 35449 RVA: 0x00249B90 File Offset: 0x00247D90
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x00249BD0 File Offset: 0x00247DD0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoneTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoneTransform>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoneTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x00041C03 File Offset: 0x0003FE03
		public BoneTransform(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x06008A7C RID: 35452 RVA: 0x00249C0C File Offset: 0x00247E0C
		// (set) Token: 0x06008A7D RID: 35453 RVA: 0x00041C0C File Offset: 0x0003FE0C
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x06008A7E RID: 35454 RVA: 0x00249C34 File Offset: 0x00247E34
		// (set) Token: 0x06008A7F RID: 35455 RVA: 0x00041C27 File Offset: 0x0003FE27
		public unsafe Quaternion _Rotation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BoneTransform.NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
			}
		}

		// Token: 0x04005E1F RID: 24095
		private static readonly System.IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04005E20 RID: 24096
		private static readonly System.IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

		// Token: 0x04005E21 RID: 24097
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04005E22 RID: 24098
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04005E23 RID: 24099
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04005E24 RID: 24100
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04005E25 RID: 24101
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
