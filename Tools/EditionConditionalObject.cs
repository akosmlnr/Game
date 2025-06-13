using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000559 RID: 1369
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x060078CE RID: 30926 RVA: 0x0020ED48 File Offset: 0x0020CF48
		// Note: this type is marked as 'beforefieldinit'.
		static EditionConditionalObject()
		{
			Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EditionConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr);
			EditionConditionalObject.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, "type");
			EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678603);
			EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678604);
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x0020EDB4 File Offset: 0x0020CFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234817, XrefRangeEnd = 234819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x0020EDE8 File Offset: 0x0020CFE8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditionConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x0003901C File Offset: 0x0003721C
		public EditionConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x0020EE24 File Offset: 0x0020D024
		// (set) Token: 0x060078D3 RID: 30931 RVA: 0x00039025 File Offset: 0x00037225
		public unsafe EditionConditionalObject.EType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04005280 RID: 21120
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04005281 RID: 21121
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005282 RID: 21122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEA RID: 2794
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x040091B1 RID: 37297
			ActiveInDemo,
			// Token: 0x040091B2 RID: 37298
			ActiveInFullGame
		}
	}
}
