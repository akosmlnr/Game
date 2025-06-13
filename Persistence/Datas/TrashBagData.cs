﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D7 RID: 727
	public class TrashBagData : TrashItemData
	{
		// Token: 0x0600333B RID: 13115 RVA: 0x0001B319 File Offset: 0x00019519
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagData()
		{
			Il2CppClassPointerStore<TrashBagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashBagData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr);
			TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr, 100669100);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00116724 File Offset: 0x00114924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137258, RefRangeEnd = 137259, XrefRangeStart = 137243, XrefRangeEnd = 137258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagData(string trashID, string guid, Vector3 position, Quaternion rotation, TrashContentData contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0001B352 File Offset: 0x00019552
		public TrashBagData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0;
	}
}
