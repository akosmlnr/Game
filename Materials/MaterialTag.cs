using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Materials
{
	// Token: 0x0200039B RID: 923
	public class MaterialTag : MonoBehaviour
	{
		// Token: 0x06004747 RID: 18247 RVA: 0x0015FFF4 File Offset: 0x0015E1F4
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialTag()
		{
			Il2CppClassPointerStore<MaterialTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Materials", "MaterialTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr);
			MaterialTag.NativeFieldInfoPtr_MaterialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, "MaterialType");
			MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, 100672143);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0016004C File Offset: 0x0015E24C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0002282D File Offset: 0x00020A2D
		public MaterialTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x00160088 File Offset: 0x0015E288
		// (set) Token: 0x0600474B RID: 18251 RVA: 0x00022836 File Offset: 0x00020A36
		public unsafe EMaterialType MaterialType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType)) = value;
			}
		}

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr_MaterialType;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
