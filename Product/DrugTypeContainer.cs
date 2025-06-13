using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005BC RID: 1468
	[System.Serializable]
	public class DrugTypeContainer : Il2CppSystem.Object
	{
		// Token: 0x06008000 RID: 32768 RVA: 0x002265C8 File Offset: 0x002247C8
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeContainer()
		{
			Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr);
			DrugTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, "DrugType");
			DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, 100679403);
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x00226620 File Offset: 0x00224820
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x0003C949 File Offset: 0x0003AB49
		public DrugTypeContainer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x06008003 RID: 32771 RVA: 0x0022665C File Offset: 0x0022485C
		// (set) Token: 0x06008004 RID: 32772 RVA: 0x0003C952 File Offset: 0x0003AB52
		public unsafe EDrugType DrugType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x04005712 RID: 22290
		private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04005713 RID: 22291
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
