using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200023A RID: 570
	public class Loader : Il2CppSystem.Object
	{
		// Token: 0x06002EA2 RID: 11938 RVA: 0x00107AF4 File Offset: 0x00105CF4
		// Note: this type is marked as 'beforefieldinit'.
		static Loader()
		{
			Il2CppClassPointerStore<Loader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "Loader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader>.NativeClassPtr);
			Loader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668683);
			Loader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668684);
			Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668685);
			Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668686);
			Loader.NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668687);
			Loader.NativeMethodInfoPtr_GetFiles_Protected_List_1_FileInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668688);
			Loader.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668689);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00107BB0 File Offset: 0x00105DB0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Loader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00107BEC File Offset: 0x00105DEC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Loader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00107C3C File Offset: 0x00105E3C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 131195, RefRangeEnd = 131225, XrefRangeStart = 131190, XrefRangeEnd = 131195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			contents = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00107CB8 File Offset: 0x00105EB8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 131234, RefRangeEnd = 131281, XrefRangeStart = 131225, XrefRangeEnd = 131234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref autoAddExtension;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			contents = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00107D30 File Offset: 0x00105F30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131299, RefRangeEnd = 131306, XrefRangeStart = 131281, XrefRangeEnd = 131299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DirectoryInfo> GetDirectories(string parentPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DirectoryInfo>>(intPtr2) : null;
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00107D80 File Offset: 0x00105F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131324, RefRangeEnd = 131326, XrefRangeStart = 131306, XrefRangeEnd = 131324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FileInfo> GetFiles(string parenPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parenPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_GetFiles_Protected_List_1_FileInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FileInfo>>(intPtr2) : null;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00107DD0 File Offset: 0x00105FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131330, RefRangeEnd = 131332, XrefRangeStart = 131326, XrefRangeEnd = 131330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize<T>(string json, out T data)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			System.IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref data;
			}
			ptr2 = intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Loader.MethodInfoStoreGeneric_TryDeserialize_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			if (!typeof(T).IsValueType)
			{
				System.IntPtr intPtr3 = intPtr;
				data = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00018DA1 File Offset: 0x00016FA1
		public Loader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EEF RID: 7919
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Protected_List_1_FileInfo_String_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0;

		// Token: 0x02000930 RID: 2352
		private sealed class MethodInfoStoreGeneric_TryDeserialize_Public_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x040088F0 RID: 35056
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Loader.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<Loader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
